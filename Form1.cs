using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Power_Cast
{
    public partial class Form1 : Form
    {
        private Socket httpServer;
        private int serverPort = 80;
        private Thread thread;

        public Form1()
        {
            InitializeComponent();
        }

        private void startServerBtn_Click(object sender, EventArgs e)
        {
            serverLogsText.Text = "";

            try 
            {
                httpServer = new Socket(SocketType.Stream, ProtocolType.Tcp);

                try
                {
                    serverPort = int.Parse(serverPortText.Text.ToString());

                    if (serverPort > 65535 || serverPort <= 0)
                    {
                        new Exception("Server Port not within range");
                    }
                }
                catch (Exception ex)
                {
                    serverPort = 80;
                    serverLogsText.Text = "Server Failed to start on specified port \n";
                }

                thread = new Thread(new ThreadStart(this.connectionThreadMethod));
                thread.Start();

                //disable and enable buttons
                startServerBtn.Enabled = false;
                stopServerBtn.Enabled = true;

            }
            catch(Exception ex) 
            {
                Console.WriteLine("Error While Starting server \n");
                serverLogsText.Text = "PCS Failed to start\n";
            }

            serverLogsText.Text = "Power Cast Server Started\n";
        }

        private void stopServerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Close the Socket
                httpServer.Close();

                // Kill the Thread
                thread.Abort();

                // Disable and Enable Buttons
                startServerBtn.Enabled = true;
                stopServerBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Stopping PCS Failed\n");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopServerBtn.Enabled = false;
        }

        private void connectionThreadMethod()
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, serverPort);
                httpServer.Bind(endpoint);
                httpServer.Listen(1);
                startListeningForConnection();
            }
            catch(Exception ex)
            {
                Console.WriteLine("i could not start");
            }
        }

        private void startListeningForConnection() 
        {
            while(true)
            {
                DateTime time = DateTime.Now;

                string data = "";
                byte[] bytes = new byte[2048];

                Socket client = httpServer.Accept(); // blocking statement

                // reading the inbound connection data
                while (true)
                {
                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    if (data.IndexOf("\r\n") > -1)
                        break;
                }

                //data read

                serverLogsText.Invoke((MethodInvoker)delegate
                {
                    // runs inside UI thread
                    serverLogsText.Text += "\r\n\r\n";
                    serverLogsText.Text += data;
                    serverLogsText.Text += "\n\n-------- End Of Request --------";

                });

                //send back responce
                String resHeader = "HTTP/1.1 200 Everything is Fine\nServer: Power_Cast_V1.0\nContent-Type: text/html; charset: UTF-8\n\n";
                String resBody = html.Text;

                String resStr = resHeader + resBody;

                byte[] resData = Encoding.ASCII.GetBytes(resStr);

                client.SendTo(resData, client.RemoteEndPoint);

                client.Close();
            }
        }
    }
}

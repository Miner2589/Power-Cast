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
using System.IO;

namespace Power_Cast
{
    public partial class Form1 : Form
    {
        private Socket httpServer;
        private int serverPort = 80;
        private Thread thread;
        private CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void startServerBtn_Click(object sender, EventArgs e)
        {
            serverLogsText.Text = ""; // Clear logs when starting the server

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
                    AppendLog("Server failed to start on the specified port, using default port 80.");
                }

                cancellationTokenSource = new CancellationTokenSource();
                thread = new Thread(() => connectionThreadMethod(cancellationTokenSource.Token));
                thread.Start();

                // Disable and enable buttons
                startServerBtn.Enabled = false;
                stopServerBtn.Enabled = true;

                AppendLog("Power Cast Server Started.");
            }
            catch (Exception ex)
            {
                AppendLog("Error while starting server: " + ex.Message);
            }
        }

        private void stopServerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Cancel the listening loop
                cancellationTokenSource?.Cancel();

                // Run shutdown code on a background thread
                Task.Run(() =>
                {
                    try
                    {
                        // Wait for the server thread to exit without blocking UI
                        thread?.Join();

                        // Close the HTTP server
                        httpServer?.Close();

                        // Update the UI safely from the UI thread
                        this.Invoke((MethodInvoker)delegate
                        {
                            startServerBtn.Enabled = true;
                            stopServerBtn.Enabled = false;
                            AppendLog("Server stopped successfully.");
                        });
                    }
                    catch (Exception ex)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            AppendLog("Error while stopping server in background: " + ex.Message);
                        });
                    }
                });
            }
            catch (Exception ex)
            {
                AppendLog("Error while initiating server stop: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopServerBtn.Enabled = false;

            // Create wwwroot folder if it doesn't exist
            string wwwrootPath = Path.Combine(Application.StartupPath, "wwwroot");

            if (!Directory.Exists(wwwrootPath))
            {
                Directory.CreateDirectory(wwwrootPath);
            }
        }

        private void connectionThreadMethod(CancellationToken token)
        {
            try
            {
                IPEndPoint endpoint = new IPEndPoint(IPAddress.Any, serverPort);
                httpServer.Bind(endpoint);
                httpServer.Listen(5);

                AppendLog("Server is listening for connections on port " + serverPort);

                while (!token.IsCancellationRequested)
                {
                    // Check if there's a pending connection (timeout: 100ms)
                    if (httpServer.Poll(100000, SelectMode.SelectRead))
                    {
                        Socket client = httpServer.Accept();
                        // Handle the connection on another thread if you want:
                        Task.Run(() => processRequestFromClient(client));

                    }
                    else
                    {
                        Thread.Sleep(10); // Prevent 100% CPU usage
                    }
                }

                AppendLog("Server loop has stopped.");
            }
            catch (Exception ex)
            {
                AppendLog("Failed to start the server: " + ex.Message);
            }
        }


        private void startListeningForConnection()
        {
            try
            {
                // Accept the client connection in a blocking way
                Socket client = httpServer.Accept(); // Blocking accept call
                AppendLog("New connection established.");

                // Process the connection asynchronously
                Task.Run(() => processRequestFromClient(client));
            }
            catch (Exception ex)
            {
                AppendLog("Error accepting connection: " + ex.Message);
            }
        }

        private void processRequestFromClient(Socket client)
        {
            try
            {
                DateTime time = DateTime.Now;
                string data = "";
                byte[] bytes = new byte[2048];

                // Read the inbound connection data
                while (true)
                {
                    int numBytes = client.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, numBytes);

                    // If we hit the end of the request (CRLF), we stop reading
                    if (data.IndexOf("\r\n") > -1)
                        break;
                }

                AppendLog("Request received: " + data);

                // Process the request and send the response back
                processRequest(data, client);
            }
            catch (Exception ex)
            {
                AppendLog("Error processing request: " + ex.Message);
            }
            finally
            {
                client.Close(); // Ensure client is closed after processing
            }
        }

        private void processRequest(string data, Socket client)
        {
            // Extract requested file from GET request
            string[] lines = data.Split('\n');
            string requestLine = lines[0]; // e.g. "GET /index.html HTTP/1.1"
            string requestedFile = "index.html"; // default fallback

            if (requestLine.StartsWith("GET"))
            {
                string[] parts = requestLine.Split(' ');
                if (parts.Length >= 2)
                {
                    string urlPath = parts[1].TrimStart('/'); // removes the leading "/"
                    if (string.IsNullOrWhiteSpace(urlPath) || urlPath == "/")
                        urlPath = "index.html";

                    requestedFile = urlPath;
                }
            }

            // Full file path to look for in the wwwroot directory
            string filePath = Path.Combine(Application.StartupPath, "wwwroot", requestedFile);

            // Response content
            string resBody = "";
            string resHeader = "";

            if (File.Exists(filePath))
            {
                resBody = File.ReadAllText(filePath);
                resHeader = "HTTP/1.1 200 OK\nServer: Power_Cast_V2.0.0\nContent-Type: text/html; charset=UTF-8\n\n";
            }
            else
            {
                resBody = "<h1>404 Not Found</h1><p>The requested page " + requestedFile + " was not found on this server.</p>";
                resHeader = "HTTP/1.1 404 Not Found\nServer: Power_Cast_V2.0.0\nContent-Type: text/html; charset=UTF-8\n\n";
            }

            string resStr = resHeader + resBody;
            byte[] resData = Encoding.ASCII.GetBytes(resStr);

            // Send the response back to the client
            client.SendTo(resData, client.RemoteEndPoint);

            AppendLog("Response sent for " + requestedFile);
        }

        // Logging function to safely update the TextBox on the UI thread
        private void AppendLog(string message)
        {
            if (serverLogsText.InvokeRequired)
            {
                serverLogsText.Invoke((MethodInvoker)delegate
                {
                    serverLogsText.Text += "\r\n" + message;
                });
            }
            else
            {
                serverLogsText.Text += "\r\n" + message;
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void wEBSITEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://stuchberycomputing.co.uk/");
        }

        private void pOWERCASTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://stuchberycomputing.co.uk/powercast/");
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://stuchberycomputing.co.uk/powercast/update.htm");
        }

        private void hELPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://stuchberycomputing.co.uk/powercast/");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void hTMLEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor ed = new editor();
            ed.Show();
        }

        private void wWWROOTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Path to the wwwroot folder
                string folderPath = Path.Combine(Application.StartupPath, "wwwroot");

                // Check if the folder exists
                if (Directory.Exists(folderPath))
                {
                    // Open the folder in Windows Explorer
                    System.Diagnostics.Process.Start("explorer.exe", folderPath);
                }
                else
                {
                    MessageBox.Show("The wwwroot folder does not exist.", "Folder Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening folder: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

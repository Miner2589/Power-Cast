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
    public partial class editor : Form
    {
        public editor()
        {
            InitializeComponent();
        }

        private void editor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "HTML Pages (*.HTML)|*.HTML|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;
                HTML.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dialSave.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(dialSave.FileName) == ".HTML")
                {
                    HTML.SaveFile(dialSave.FileName, RichTextBoxStreamType.PlainText);

                }

                if (Path.GetExtension(dialSave.FileName) == ".TXT")
                {
                    HTML.SaveFile(dialSave.FileName, RichTextBoxStreamType.PlainText);

                }
            }
        }

        private void openFolderBtn_Click(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

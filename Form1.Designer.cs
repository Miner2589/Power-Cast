namespace Power_Cast
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startServerBtn = new System.Windows.Forms.Button();
            this.stopServerBtn = new System.Windows.Forms.Button();
            this.serverPortText = new System.Windows.Forms.TextBox();
            this.serverLogsText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wEBSITEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hELPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOWERCASTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wWWROOTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dialSave = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // startServerBtn
            // 
            this.startServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startServerBtn.Location = new System.Drawing.Point(98, 127);
            this.startServerBtn.Name = "startServerBtn";
            this.startServerBtn.Size = new System.Drawing.Size(84, 74);
            this.startServerBtn.TabIndex = 0;
            this.startServerBtn.Text = "Start Server";
            this.startServerBtn.UseVisualStyleBackColor = true;
            this.startServerBtn.Click += new System.EventHandler(this.startServerBtn_Click);
            // 
            // stopServerBtn
            // 
            this.stopServerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopServerBtn.Location = new System.Drawing.Point(8, 127);
            this.stopServerBtn.Name = "stopServerBtn";
            this.stopServerBtn.Size = new System.Drawing.Size(84, 74);
            this.stopServerBtn.TabIndex = 1;
            this.stopServerBtn.Text = "Stop Server";
            this.stopServerBtn.UseVisualStyleBackColor = true;
            this.stopServerBtn.Click += new System.EventHandler(this.stopServerBtn_Click);
            // 
            // serverPortText
            // 
            this.serverPortText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverPortText.CausesValidation = false;
            this.serverPortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverPortText.Location = new System.Drawing.Point(200, 173);
            this.serverPortText.Name = "serverPortText";
            this.serverPortText.Size = new System.Drawing.Size(139, 22);
            this.serverPortText.TabIndex = 2;
            // 
            // serverLogsText
            // 
            this.serverLogsText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serverLogsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLogsText.Location = new System.Drawing.Point(12, 238);
            this.serverLogsText.Multiline = true;
            this.serverLogsText.Name = "serverLogsText";
            this.serverLogsText.ReadOnly = true;
            this.serverLogsText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.serverLogsText.Size = new System.Drawing.Size(815, 417);
            this.serverLogsText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Server Logs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Server Access Port (SAP)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 679);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(843, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpSupportToolStripMenuItem,
            this.hTMLEditorToolStripMenuItem,
            this.wWWROOTToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpSupportToolStripMenuItem
            // 
            this.helpSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uPDATEToolStripMenuItem,
            this.wEBSITEToolStripMenuItem,
            this.hELPToolStripMenuItem,
            this.pOWERCASTToolStripMenuItem});
            this.helpSupportToolStripMenuItem.Name = "helpSupportToolStripMenuItem";
            this.helpSupportToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.helpSupportToolStripMenuItem.Text = "Help + Support";
            // 
            // uPDATEToolStripMenuItem
            // 
            this.uPDATEToolStripMenuItem.Name = "uPDATEToolStripMenuItem";
            this.uPDATEToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.uPDATEToolStripMenuItem.Text = "UPDATE";
            this.uPDATEToolStripMenuItem.Click += new System.EventHandler(this.uPDATEToolStripMenuItem_Click);
            // 
            // wEBSITEToolStripMenuItem
            // 
            this.wEBSITEToolStripMenuItem.Name = "wEBSITEToolStripMenuItem";
            this.wEBSITEToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.wEBSITEToolStripMenuItem.Text = "WEBSITE";
            this.wEBSITEToolStripMenuItem.Click += new System.EventHandler(this.wEBSITEToolStripMenuItem_Click);
            // 
            // hELPToolStripMenuItem
            // 
            this.hELPToolStripMenuItem.Name = "hELPToolStripMenuItem";
            this.hELPToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.hELPToolStripMenuItem.Text = "HELP";
            this.hELPToolStripMenuItem.Click += new System.EventHandler(this.hELPToolStripMenuItem_Click);
            // 
            // pOWERCASTToolStripMenuItem
            // 
            this.pOWERCASTToolStripMenuItem.Name = "pOWERCASTToolStripMenuItem";
            this.pOWERCASTToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.pOWERCASTToolStripMenuItem.Text = "POWER CAST";
            this.pOWERCASTToolStripMenuItem.Click += new System.EventHandler(this.pOWERCASTToolStripMenuItem_Click);
            // 
            // hTMLEditorToolStripMenuItem
            // 
            this.hTMLEditorToolStripMenuItem.Name = "hTMLEditorToolStripMenuItem";
            this.hTMLEditorToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.hTMLEditorToolStripMenuItem.Text = "HTML Editor";
            this.hTMLEditorToolStripMenuItem.Click += new System.EventHandler(this.hTMLEditorToolStripMenuItem_Click);
            // 
            // wWWROOTToolStripMenuItem
            // 
            this.wWWROOTToolStripMenuItem.Name = "wWWROOTToolStripMenuItem";
            this.wWWROOTToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.wWWROOTToolStripMenuItem.Text = "WWWROOT";
            this.wWWROOTToolStripMenuItem.Click += new System.EventHandler(this.wWWROOTToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(278, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Black", 17.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 32);
            this.label7.TabIndex = 20;
            this.label7.Text = "V2.0.1";
            // 
            // dialSave
            // 
            this.dialSave.Filter = "HTML Pages (*.HTML)|*.HTML|All Files (*.*)|*.*";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(-1, 113);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 103);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(98, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(251, 103);
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Location = new System.Drawing.Point(259, 113);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(583, 103);
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::Power_Cast.Properties.Resources.power_cast_banner_blank_version;
            this.pictureBox5.Location = new System.Drawing.Point(-1, 21);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(425, 100);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(-1, 214);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(844, 453);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 697);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverPortText);
            this.Controls.Add(this.stopServerBtn);
            this.Controls.Add(this.startServerBtn);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.serverLogsText);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(856, 736);
            this.MinimumSize = new System.Drawing.Size(856, 736);
            this.Name = "Form1";
            this.Text = "Power Cast - Stuchbery Software";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startServerBtn;
        private System.Windows.Forms.Button stopServerBtn;
        private System.Windows.Forms.TextBox serverPortText;
        private System.Windows.Forms.TextBox serverLogsText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wEBSITEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hELPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOWERCASTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ToolStripMenuItem hTMLEditorToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dialSave;
        private System.Windows.Forms.ToolStripMenuItem wWWROOTToolStripMenuItem;
    }
}


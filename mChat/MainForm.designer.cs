namespace WindowsFormsApplication1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NAME = new System.Windows.Forms.ColumnHeader();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.Main = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.awaitingWhispers = new System.Windows.Forms.ListBox();
            this.About = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alllowedWhispers = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.charlist = new System.Windows.Forms.ComboBox();
            this.realmlist = new System.Windows.Forms.ComboBox();
            this.password = new System.Windows.Forms.MaskedTextBox();
            this.host = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabs = new System.Windows.Forms.TabControl();
            this.Log = new System.Windows.Forms.TabPage();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1.SuspendLayout();
            this.Main.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.About.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabs.SuspendLayout();
            this.Log.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connStatus,
            this.toolStripStatusLabel2});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 478);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(593, 20);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.TabStop = true;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // connStatus
            // 
            this.connStatus.Name = "connStatus";
            this.connStatus.Size = new System.Drawing.Size(72, 15);
            this.connStatus.Text = "Disconnected";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(109, 15);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // Main
            // 
            this.Main.Controls.Add(this.groupBox4);
            this.Main.Controls.Add(this.button7);
            this.Main.Controls.Add(this.button6);
            this.Main.Controls.Add(this.button3);
            this.Main.Controls.Add(this.button2);
            this.Main.Controls.Add(this.groupBox3);
            this.Main.Controls.Add(this.About);
            this.Main.Controls.Add(this.groupBox2);
            this.Main.Controls.Add(this.groupBox1);
            this.Main.Location = new System.Drawing.Point(4, 22);
            this.Main.Name = "Main";
            this.Main.Padding = new System.Windows.Forms.Padding(3);
            this.Main.Size = new System.Drawing.Size(584, 446);
            this.Main.TabIndex = 0;
            this.Main.Text = "Main";
            this.Main.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Location = new System.Drawing.Point(201, 224);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(183, 215);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Others";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(11, 60);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(165, 35);
            this.button8.TabIndex = 1;
            this.button8.Text = "Start Whisper";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(11, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Join Channel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(492, 415);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 24);
            this.button7.TabIndex = 8;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(391, 415);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 24);
            this.button6.TabIndex = 7;
            this.button6.Text = "Add";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.awaitingWhispers);
            this.groupBox3.Location = new System.Drawing.Point(391, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 204);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Awaiting Whispers";
            // 
            // awaitingWhispers
            // 
            this.awaitingWhispers.FormattingEnabled = true;
            this.awaitingWhispers.Location = new System.Drawing.Point(6, 19);
            this.awaitingWhispers.Name = "awaitingWhispers";
            this.awaitingWhispers.Size = new System.Drawing.Size(173, 173);
            this.awaitingWhispers.TabIndex = 1;
            // 
            // About
            // 
            this.About.Controls.Add(this.label6);
            this.About.Location = new System.Drawing.Point(10, 224);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(183, 215);
            this.About.TabIndex = 3;
            this.About.TabStop = false;
            this.About.Text = "About";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 182);
            this.label6.TabIndex = 0;
            this.label6.Text = "Author:\r\nMaku - michalkaluzny@gmail.com\r\n\r\nThanks to:\r\nBoogieman, Burlex, \r\nWCell" +
                " Team, Nivelo\r\n\r\n\r\n\r\n\r\n\r\nIf you lake this app, please send\r\nme a a dollar or two" +
                " by paypal\r\nto maku@boo.pl";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alllowedWhispers);
            this.groupBox2.Location = new System.Drawing.Point(390, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Allowed Whispers";
            // 
            // alllowedWhispers
            // 
            this.alllowedWhispers.FormattingEnabled = true;
            this.alllowedWhispers.Location = new System.Drawing.Point(8, 16);
            this.alllowedWhispers.Name = "alllowedWhispers";
            this.alllowedWhispers.Size = new System.Drawing.Size(173, 134);
            this.alllowedWhispers.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.charlist);
            this.groupBox1.Controls.Add(this.realmlist);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.host);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(10, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 211);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Character";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Realm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Realmlist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // charlist
            // 
            this.charlist.Enabled = false;
            this.charlist.FormattingEnabled = true;
            this.charlist.Location = new System.Drawing.Point(141, 129);
            this.charlist.Name = "charlist";
            this.charlist.Size = new System.Drawing.Size(226, 21);
            this.charlist.TabIndex = 5;
            // 
            // realmlist
            // 
            this.realmlist.Enabled = false;
            this.realmlist.FormattingEnabled = true;
            this.realmlist.Location = new System.Drawing.Point(141, 102);
            this.realmlist.Name = "realmlist";
            this.realmlist.Size = new System.Drawing.Size(226, 21);
            this.realmlist.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(141, 76);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(226, 20);
            this.password.TabIndex = 3;
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(141, 24);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(227, 20);
            this.host.TabIndex = 2;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(141, 50);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(227, 20);
            this.login.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(6, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 30);
            this.button5.TabIndex = 1;
            this.button5.Text = "Disconnect";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.Main);
            this.tabs.Controls.Add(this.Log);
            this.tabs.Location = new System.Drawing.Point(0, 6);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(592, 472);
            this.tabs.TabIndex = 1;
            // 
            // Log
            // 
            this.Log.Controls.Add(this.logBox);
            this.Log.Location = new System.Drawing.Point(4, 22);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(3);
            this.Log.Size = new System.Drawing.Size(584, 446);
            this.Log.TabIndex = 1;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            this.logBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.logBox.Location = new System.Drawing.Point(-4, 0);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(593, 446);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 498);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Main.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.Log.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel connStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.TabPage Main;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox About;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox awaitingWhispers;
        private System.Windows.Forms.ListBox alllowedWhispers;
        private System.Windows.Forms.MaskedTextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox charlist;
        private System.Windows.Forms.ComboBox realmlist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.TabPage Log;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
    }
}


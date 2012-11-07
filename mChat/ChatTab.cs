using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mClient.Shared;
using mClient.Constants;

namespace WindowsFormsApplication1
{
    public class ChatTab : System.Windows.Forms.TabPage
    {
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListBox listBox1;

        public String Identificator;
        public ChatMsg Type;

        public ChatTab()
        {
        }

        public ChatTab(string ident, ChatMsg type)
        {
            #region Do NOT open this shit.
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Controls.Add(this.button3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.listBox1);
            this.Location = new System.Drawing.Point(4, 22);
            this.Name = "";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(584, 446);
            this.TabIndex = 1;
            this.Text = "Chat Window";
            this.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(435, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(143, 160);
            this.listBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(429, 343);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.Multiline = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Chat";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Close Tab";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(5, 367);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(428, 67);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            this.richTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(richTextBox2_KeyPress);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 367);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 66);
            this.button3.TabIndex = 6;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            #endregion

            Identificator = ident;
            Type = type;
            this.Text = String.Format("[{0}] {1}", type, Identificator);
        }

        void richTextBox2_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            Console.WriteLine((int)e.KeyChar);
            if ((int)e.KeyChar == 13)
            {
                button3_Click(null, null);
            }
            else if ((int)e.KeyChar == 10)
            {
                this.richTextBox2.AppendText("\n");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication1.Program.test.RemoveTab(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string to = "";
            string msg = this.richTextBox2.Text.TrimEnd(new char[] {(char)10});
            if (Type == ChatMsg.Whisper || Type == ChatMsg.Channel)
            {
                to = Identificator;
            }
            if (Type == ChatMsg.Whisper)
            {
                AddMessage(msg, WindowsFormsApplication1.Program.test.wl.objectMgr.getPlayerObject().Name);
            }

 
            WindowsFormsApplication1.Program.test.wl.SendChatMsg(Type, lang, msg , to);
            this.richTextBox2.Text = "";
            
        }

        public void AddMessage(string message, string user)
        {
            string msg = String.Format("[{0}][{1}] {2}", Time.GetTime(), user, message);
            msg = msg.TrimEnd(new char[] {(char)10});
            this.richTextBox1.AppendText(msg);
            this.richTextBox1.AppendText("\n");
        }
    }
}

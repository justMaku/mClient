using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mClient.Constants;

namespace WindowsFormsApplication1
{
    public partial class AddName : Form
    {
        private ChatMsg Type;
        public AddName(ChatMsg type)
        {
            Type = type;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != null)
            {
                if (Type == ChatMsg.Whisper)
                {
                    ChatTab nTab = new ChatTab(this.textBox1.Text, Type);
                    WindowsFormsApplication1.Program.test.AddTab(nTab);
                    this.Close();
                }
                else if (Type == ChatMsg.Channel)
                {
                    WindowsFormsApplication1.Program.test.wl.JoinChannel(this.textBox1.Text, "");
                    ChatTab nTab = new ChatTab(this.textBox1.Text, Type);
                    WindowsFormsApplication1.Program.test.AddTab(nTab);
                    this.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using mClient.Clients;
using mClient.Network;
using mClient.Shared;
using mClient.Constants;
using mClient.Terrain;
using mClient;


namespace WindowsFormsApplication1
{
    public partial class MainForm : Form
    {
        public LogonServerClient cl;
        public WorldServerClient wl;
        private ServiceType Status = ServiceType.None;
        private List<ChatTab> Tabs = new List<ChatTab>();


        public MainForm()
        {
            InitializeComponent();
            
        }

        public void EventHandler(Event e)
        {
            switch (e.eventType)
            {
                case EventType.EVENT_REALMLIST:
                    HandleRealmlist((Realm[])e.eventArgs[0]);
                    break;
                case EventType.EVENT_CHARLIST:
                    HandleCharlist((Character[])e.eventArgs[0]);
                    break;
                case EventType.EVENT_LOG:
                    HandleLog((string)e.eventArgs[0]);
                    break;
                case EventType.EVENT_CHAT_MSG:
                    HandleChatMsg((ChatMsg)e.eventArgs[0], (string)e.eventArgs[1],(string)e.eventArgs[2], (string)e.eventArgs[3]);
                    break;
                case EventType.EVENT_ERROR:
                    MessageBox.Show((string)e.eventArgs[0], "Error!");
                    break;
                case EventType.EVENT_DISCONNECT:
                    HandleDisconnect();
                    break;

            }
        }

        public void AddTab(ChatTab tab)
        {
            Tabs.Add(tab);
            tabs.Controls.Add(tab);
        }

        public void RemoveTab(ChatTab tab)
        {
            Tabs.Remove(tab);
            tabs.Controls.Remove(tab);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Status == ServiceType.None)
            {
                if (host.Text == "" || login.Text == "" || password.Text == "")
                {
                    MessageBox.Show("Please insert your logon data", "Error!");
                    return;
                }
                cl = new LogonServerClient(host.Text, login.Text, password.Text);

                cl.Connect();
                button1.Enabled = false;
                realmlist.Enabled = true;
            }
            else if (Status == ServiceType.Logon)
            {
                Realm rl = new Realm();
                if (realmlist.SelectedItem != null)
                {
                    rl = cl.Realmlist.First(s => s.Name == realmlist.SelectedItem.ToString());
                }
                else
                {
                    HandleDisconnect();
                    return;
                }
                wl = new WorldServerClient(login.Text, rl, cl.mKey);
                //cl.HardDisconnect();
                wl.Connect();
                button1.Enabled = false;
                charlist.Enabled = true;
                realmlist.Enabled = false;
                this.UseWaitCursor = true;
            }
            else if (Status == ServiceType.World)
            {
                Character rl = wl.Charlist.First(s => s.Name == charlist.SelectedItem.ToString());
                if (rl.Name == null)
                    return;

                wl.LoginPlayer(rl);

                this.Text = String.Format("[{0}][{1}] {2} - {3} on {4}:3724", rl.Race, rl.Class, rl.Name, wl.realm.Name, wl.realm.Address);

                
                button1.Enabled = false;
                charlist.Enabled = false;
                ChatTab cTab = new ChatTab("", ChatMsg.Say);
                AddTab(cTab);
            }

        }

        private void HandleRealmlist(Realm[] list)
        {
            foreach (Realm rl in list)
            {
                if (realmlist.Items.Contains(rl.Name))
                    return; 
                this.realmlist.Items.Add(rl.Name);
            }
            button1.Text = "Connect to Realm Server";
            button1.Enabled = true;
            Status = ServiceType.Logon;
        }

        private void HandleCharlist(Character[] list)
        {
            this.UseWaitCursor = false;
            foreach (Character rl in list)
            {
                if (charlist.Items.Contains(rl.Name))
                    return;
                this.charlist.Items.Add(rl.Name);
            }
            button1.Text = "Connect to World Server";
            button1.Enabled = true;
            Status = ServiceType.World;
        }

        private void HandleLog(string msg)
        {
            logBox.AppendText(msg);
            logBox.AppendText("\n");
        }

        private void HandleChatMsg(ChatMsg type, string channel, string user, string msg)
        {
            ChatTab found = new ChatTab();
            
            if (type == ChatMsg.Say || type == ChatMsg.Yell)
            {
                found = Tabs.Find(s => s.Type == ChatMsg.Say);
            }

            else if (type == ChatMsg.System || type == ChatMsg.System2)
            {
                type = ChatMsg.System;
                found = Tabs.Find(s => s.Type == ChatMsg.System);
            }

            else if (type == ChatMsg.Guild)
            {
                found = Tabs.Find(s => s.Type == type);
            }

            else if (type == ChatMsg.Channel)
            {
                found = Tabs.Find(s => s.Identificator == channel);
            }

            else if (type == ChatMsg.Whisper)
            {
                found = Tabs.Find(s => s.Identificator == user);
            }
            if (found == null)
            {
                ChatTab nTab = new ChatTab();
                if (type == ChatMsg.Channel)
                {
                    nTab = new ChatTab(channel, type);
                }
                else
                {
                    nTab = new ChatTab(user, type);
                }
                nTab.AddMessage(msg, user);
                tabs.TabPages.Add(nTab);
                Tabs.Add(nTab);
            }
            else
            {
                found.AddMessage(msg, user);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            HandleDisconnect();
        }

        private void HandleDisconnect()
        {
            if (cl != null)
            {
                cl.HardDisconnect();
                cl = null;
            }
            if (wl != null)
            {
                wl.HardDisconnect();
                cl = null;
            }

            charlist.Items.Clear();
            realmlist.Items.Clear();
            charlist.Enabled = false;
            realmlist.Enabled = false;
            Status = ServiceType.None;
            button1.Text = "Connect";
            button1.Enabled = true;
            UseWaitCursor = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AddName addForm = new AddName(ChatMsg.Channel);

            addForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddName addForm = new AddName(ChatMsg.Whisper);

            addForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


    }
}

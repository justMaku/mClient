using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using mClient;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static MainForm test;
       
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            mCore.Init(EventHandler);

            test = new MainForm();
            
            Application.Run(test);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            
        }

        static void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (test.cl != null)
            {
                test.cl.Disconnect();
                test.cl = null;
            }
            if (test.wl != null)
            {
                test.wl.Disconnect();
                test.cl = null;
            }
        }

        delegate void EventInvoke(Event e);

        // Event Handler
        public static void EventHandler(Event e)
        {
            if (test.InvokeRequired)
                test.Invoke(new EventInvoke(EventHandler), new object[1] { e });
            else
                test.EventHandler(e);
        }

    }
}

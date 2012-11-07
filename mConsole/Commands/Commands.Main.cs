using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using mClient;
using mClient.Clients;
using mClient.Constants;
using mClient.Shared;
using mConsole.Commands;

namespace mConsole
{
    partial class mConsole
    {
        [CommandHandlerAtribute("LServer", "Connect")]
        public static void ConnectToLS()
        {
            try
            {
                lclient = new LogonServerClient(Config.Host, Config.Login, Config.Password);
                lclient.Connect();
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, "Exception Occured");
                Log.WriteLine(LogType.Error, "Message: {0}", ex.Message);
                Log.WriteLine(LogType.Error, "Stacktrace: {0}", ex.StackTrace);
            }
        }

        [CommandHandlerAtribute("WServer", "Connect")]
        public static void ConnectToWS(string[] c)
        {
            int x = Convert.ToInt32(c[0]) - 1;
            try
            {
                if (lclient == null || lclient.Connected == false || lclient.Realmlist.Length < 1)
                {
                    Log.WriteLine(LogType.Error, "Please connect to the logon server first.");
                    return;
                }
                lclient.HardDisconnect();
                wclient = new WorldServerClient(Config.Login, lclient.Realmlist[x], lclient.mKey);
                wclient.Connect();
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, "Exception Occured");
                Log.WriteLine(LogType.Error, "Message: {0}", ex.Message);
                Log.WriteLine(LogType.Error, "Stacktrace: {0}", ex.StackTrace);
            }
        }

        [CommandHandlerAtribute("WServer", "Login")]
        public static void LoginToWS(string[] c)
        {
            int x = Convert.ToInt32(c[0]) - 1;
            try
            {
                wclient.LoginPlayer(wclient.Charlist[x]);
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, "Exception Occured");
                Log.WriteLine(LogType.Error, "Message: {0}", ex.Message);
                Log.WriteLine(LogType.Error, "Stacktrace: {0}", ex.StackTrace);
            }
        }

        [CommandHandlerAtribute("Exit")]
        public static void tsExit()
        {
            Environment.Exit(0);
        }

    }
}
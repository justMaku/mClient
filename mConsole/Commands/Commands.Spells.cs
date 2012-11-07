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
        [CommandHandlerAtribute("Spell", "Cast")]
        public static void CastSpell(string[] c)
        {
            int x = Convert.ToInt32(c[0]);
            try
            {
                wclient.CastSpell(wclient.objectMgr.getPlayerObject(), 168);
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, "Exception Occured");
                Log.WriteLine(LogType.Error, "Message: {0}", ex.Message);
                Log.WriteLine(LogType.Error, "Stacktrace: {0}", ex.StackTrace);
            }
        }

    }
}
using System;
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
        [CommandHandlerAtribute("Objects", "List")]
        public static void ListObjects()
        {
            try
            {
                int x = 1;
                foreach (mClient.Clients.Object obj in wclient.objectMgr.getObjectArray())
                {
                    Log.WriteLine(LogType.Normal, "{0}. {1} - {2}", x, obj.Name, obj.Guid.GetOldGuid());
                    x++;
                }
            }
            catch (Exception ex)
            {
                Log.WriteLine(LogType.Error, "Exception Occured");
                Log.WriteLine(LogType.Error, "Message: {0}", ex.Message);
                Log.WriteLine(LogType.Error, "Stacktrace: {0}", ex.StackTrace);
            }
        }

        [CommandHandlerAtribute("Objects", "Debug")]
        public static void ListObjects(string[] c)
        {
            int i = Convert.ToInt32(c[0]) - 1;
            try
            {
                mClient.Clients.Object test = wclient.objectMgr.getObjectArray()[i];
                for (int x = 1; x < (int)UpdateFields.FIELDS_MAX; x++ )
                {
                    if (test.Fields[x] != 0)
                        Log.WriteLine(LogType.Normal, "{0} = {1}", (UpdateFields)x, test.Fields[x]);
                }
                
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
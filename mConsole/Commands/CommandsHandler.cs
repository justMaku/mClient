using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Net.Sockets;
using System.Threading;

using mClient.Shared;

namespace mConsole.Commands
{
    class CommandHandler
    {
        static string cmd, fam;
        static string[] arg;

        static List<CommandHandle> Handles;

        static CommandHandler()
        {
            Handles = new List<CommandHandle>();
        }

        public static void Initialize()
        {
            CommandHandlerAtribute atribute;
            Assembly asm = Assembly.GetExecutingAssembly();
            int x = 0;
            foreach (Type asmType in asm.GetTypes())
            {

                foreach (MethodInfo method in asmType.GetMethods())
                {
                    foreach (Attribute attr in method.GetCustomAttributes(true))
                    {
                        atribute = attr as CommandHandlerAtribute;
                        if (null != atribute)
                        {
                            CommandHandle handle = new CommandHandle(method, atribute.command, atribute.family);
                            Handles.Add(handle);
                            x++;
                        }
                    }
                }
            }
            Log.WriteLine(LogType.Success, "Loaded {0} Command handlers.", x);
        }

        static public void HandleCommand(String commandstring)
        {
            if (commandstring == "")
                return;
            string[] command = commandstring.Split(' ');
            System.Object[] param = { null };
            if (command.Length == 1)
            {
                cmd = command[0];
                fam = "MAIN";
                param = null;
            }
            else if (command.Length == 2)
            {
                fam = command[0];
                cmd = command[1];
                param = null;
            }
            else if (command.Length > 2)
            {
                fam = command[0];
                cmd = command[1];
                arg = command.Skip(2).ToArray();
                if (arg.Length == 1)
                {
                    param[0] = arg ;
                }
                else if (arg.Length > 1)
                {
                    param[0] = arg ;
                }
            }
            CommandHandle handle = Handles.Find(s => s.family == fam && s.command == cmd);
            if (handle != null)
            {
                try
                {
                    System.Object obj = null;
                    handle.MethodInfo.Invoke(obj, param);
               
                }
                catch (Exception ex)
                {
                    Log.WriteLine(LogType.Error, "Exception Occured");
                    Log.WriteLine(LogType.Error, "Message: {0}", ex.Message);
                    Log.WriteLine(LogType.Error, "Stacktrace: {0}", ex.StackTrace);
                }
            }
            else
            {
      
                Log.WriteLine(LogType.Error, "Command not found: {0}", commandstring);
            }
        }

   }
    
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class CommandHandlerAtribute : Attribute
    {
        public CommandHandlerAtribute(string command)
        {
            this.command = command;
            this.family = "MAIN";
        }

        public CommandHandlerAtribute(string family, string command)
        {
            this.command = command;
            this.family = family;
        }

        public string command;
        public string family;

    }

    public class CommandHandle
    {
        public MethodInfo MethodInfo;
        public string command;
        public string family;

        public CommandHandle(MethodInfo info, string command, string family)
        {
            this.MethodInfo = info;
            this.command = command;
            this.family = family;
        }
    }
}

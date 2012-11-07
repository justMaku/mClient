using System;
using mClient.Constants;

namespace mClient
{
    public static class Config
    {
        public static string Login;
        public static string Password;
        public static string Host;
        public static WoWVersion Version;
        public static long LogFilter;
        public static bool Retail;
        public static bool LogToFile;

        static Config()
        {
            Login = "";
            Password = "";
            Host = "";

            Version.major = 3;
            Version.minor = 3;
            Version.update = 3;
            Version.build = 11723;


            Retail = false;

            LogFilter = 0x0000000000000000;
            LogToFile = true;
        }
    }
}

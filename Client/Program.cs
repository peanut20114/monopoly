using System;
using System.Windows.Forms;
using DotNetEnv;

namespace Client
{
    internal static class Program
    {
        public static ColorChoosing colorChoosing;
        public static string SessionID;
        public static string UserID;
        public static string UserName;
        public static int UserRank;
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DotNetEnv.Env.Load("./secret.env");
            Application.Run(new Account());
        }
    }
    internal class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string birthday { get; set; }
        public string country { get; set; }
        public string email { get; set; }
        public string intro { get; set; }
        public DateTime last_logged_in { get; set; }
        public DateTime register_at { get; set; }
        public int score { get; set; }
        public int[] friends { get; set; }
    }
    internal class Session
    {
        public string redPawn { get; set; }
        public string bluePawn { get; set; }
        public int winner { get; set; } // 0 is Red, 1 is Blue
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set; }
    }
    internal static class Gamemodes
    {
        public static bool Singleplayer { get; set; }
        public static bool Multiplayer { get; set; }
    }

    internal static class ConnectionOptions
    {
        public static string IP { get; set; }
        public static int Port { get; set; }
        public static string PlayerName { get; set; }
        public static bool NameRedIsTaken { get; set; }
        public static bool NameBlueIsTaken { get; set; }
    }
}
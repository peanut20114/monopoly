using System;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        public static ColorChoosing colorChoosing;
        public static string UserID;
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Account());
           // Application.Run(new MainMenu());
        }
    }

    internal class User
    {
        public string ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Birthday { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Last_Logged_In { get; set; }
        public int[] Friends { get; set; }
        public string Register_At { get; set; }
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
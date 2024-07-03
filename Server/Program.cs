using System;
using System.Windows.Forms;

namespace Server
{
    internal static class Program
    {
        public static ServerForm f;
        public static string sessionID;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ServerForm());
        }
    }
    internal static class Taken
    {
        public static bool Red { get; set; }
        public static bool Blue { get; set; }
    }
    internal class Session
    {
        public string redPawn { get; set; }
        public string bluePawn { get; set; }
        public int winner { get; set; } // 0 is Red, 1 is Blue
        public string start_at { get; set; }
        public string end_at { get; set; }
    }
}

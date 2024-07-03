﻿using System;
using System.Windows.Forms;

namespace Client
{
    internal static class Program
    {
        public static ColorChoosing colorChoosing;
        public static string UserID;
        public static string UserName;
        public static int UserRank;
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
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
        public string last_logged_in { get; set; }
        public string register_at { get; set; }
        public int[] friends { get; set; }
    }
    internal class Leaderboard
    {
        public string user_id { get; set; }
        public int rank { get; set; }
        public int score { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
    }
    internal class Session
    {
        public string[] user_id { get; set; }
        public int result { get; set; }
        public int module_play { get; set; }
        public DateTime start_at { get; set; }
        public DateTime end_at { get; set; }
        public string winner {  get; set; }
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
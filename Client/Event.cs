using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Event : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public Event()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
            Load();
        }
        private async void Load()
        {
            int numWins = await getNumberOfWins(Program.UserID);
            int numGames = await getNumberOfGames(Program.UserID);

            listView1.View = View.Details;
            listView1.Scrollable = false;
            listView1.FullRowSelect = true;


            // Add columns to the ListView.
            listView1.Columns.Add("Event", 210, HorizontalAlignment.Center);
            listView1.Columns.Add("Start At", 125, HorizontalAlignment.Center);
            listView1.Columns.Add("End At", 125, HorizontalAlignment.Center);
            listView1.Columns.Add("Status", 100, HorizontalAlignment.Center);
            string[] missions = { "Complete 1 Game", "Complete 2 Games", "Complete 3 Games", "Online 20 minutes", "Win 1 game", "Win 2 games", "Win 2 consecutive games" };
            string[] eventStats = checkMissions(missions, numWins, numGames);
            for (int i = 0; i < 7; i++)
            {
                // Create a new ListViewItem with the event name.
                ListViewItem item = new ListViewItem($"{missions[i]}");

                // Generate random start and end times for the event.
                DateTime startTime = GetRandomDateTime(DateTime.Now, DateTime.Now.AddDays(7));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, startTime.ToString("dd/MM/yyyy HH:mm:ss")));

                DateTime endTime = startTime.AddDays(7);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, endTime.ToString("dd/MM/yyyy HH:mm:ss")));

                // Determine the event status and add it as a subitem.
                //string eventStatus = GetEventStatus(startTime, endTime);
                //ListViewItem.ListViewSubItem statusSubItem = new ListViewItem.ListViewSubItem(item, eventStatus);

                Random random = new Random();
                int randomNumber = random.Next(0, 2);
                string eventStatus = eventStats[i];

                ListViewItem.ListViewSubItem statusSubItem = new ListViewItem.ListViewSubItem(item, eventStatus);
                // Change the color based on the status.
                if (eventStatus == "Finished")
                {
                    statusSubItem.ForeColor = Color.LightGreen; // Completed missions are highlighted in green.
                }
                else if (eventStatus == "Ongoing")
                {
                    statusSubItem.ForeColor = Color.LightYellow; // Ongoing missions are highlighted in yellow.
                }
                else
                {
                    statusSubItem.ForeColor = Color.LightCoral; // Future missions are highlighted in red.
                }

                item.SubItems.Add(statusSubItem);

                // Add the item to the ListView.
                listView1.Items.Add(item);
            }
        }
        string GetEventStatus(DateTime startTime, DateTime endTime)
        {
            return "hello";
        }

        // Method to generate a random DateTime within a specified range.
        DateTime GetRandomDateTime(DateTime start, DateTime end)
        {
            Random rnd = new Random();
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        
        public async Task<int> getNumberOfWins(string userID)
        {
            FirebaseResponse res = await client.GetAsync("SESSION/");
            Dictionary<string, Session> sessions = res.ResultAs<Dictionary<string, Session>>();
            int wins = 0;
            foreach (var sess in sessions.Values)
            {
                if ((sess.winner == 0 && sess.redPawn == userID) ||
                    (sess.winner == 1 && sess.bluePawn == userID))
                {
                    wins++;
                }
            }
            return wins;
        }

        public string[] checkMissions(string[] missions, int numWins, int numGames)
        {
            //string[] missions = { "Complete 1 Game", "Complete 2 Games", "Complete 3 Games", "Online 20 minutes", "Win 1 game", "Win 2 games", "Win 2 consecutive games" };
            string[] eventStats = { "Ongoing", "Ongoing", "Ongoing", "Ongoing", "Ongoing", "Ongoing", "Ongoing" };
            if (numGames >= 1)
                eventStats[0] = "Finished";
            if (numGames >= 2)
                eventStats[1] = "Finished";
            if (numGames >= 3)
                eventStats[2] = "Finished";
            if (numWins >= 1)
                eventStats[4] = "Finished";
            if (numGames >= 2)
                eventStats[5] = "Finished";
            return eventStats;
        }

        public async Task<int> getNumberOfGames(string userID)
        {
            FirebaseResponse res = await client.GetAsync("SESSION/");
            Dictionary<string, Session> sessions = res.ResultAs<Dictionary<string, Session>>();
            int wins = 0;
            foreach (var sess in sessions.Values)
            {
                if ((sess.redPawn == userID) ||
                    ( sess.bluePawn == userID))
                {
                    wins++;
                }
            }
            return wins;
        }

        

        public static string[] AppendToArray(string[] originalArray, string newValue)
        {
            int originalLength = originalArray.Length;
            string[] newArray = new string[originalLength + 1];

            for (int i = 0; i < originalLength; i++)
            {
                newArray[i] = originalArray[i];
            }

            newArray[originalLength] = newValue;

            return newArray;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

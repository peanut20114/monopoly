using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Mission : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        DateTime?[] rewarded = new DateTime?[10];
        string[] daily = { "Complete 1 Game", "Complete 2 Games", "Complete 3 Games", "Complete 5 Games",
                "Complete 10 Games", "Win 1 game", "Win 2 games", "Win 3 game", "Win 5 game", "Win 10 game" };
        int[] daily_bonus = { 1, 2, 3, 5, 2, 4, 8, 5, 10, 15 };
        public Mission()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }
        public async Task<string> check_completed(int n)
        {
            DateTime today = DateTime.Today;
            FirebaseResponse res = await client.GetAsync("SESSION/");
            JObject jsonResponse = JObject.Parse(res.Body.ToString());

            List<JToken> filteredSessions = new List<JToken>();
            foreach (var session in jsonResponse.Children())
            {
                JToken startAtToken = session.First()["start_at"];
                if (startAtToken != null && startAtToken.ToObject<DateTime>().Date == today)
                {
                    filteredSessions.Add(session.First());
                }
            }

            if (filteredSessions.Count == n)
            {
                return "Completed";
            }

            return "Not Completed";
        }
        public async Task<string> check_wins(int n)
        {
            DateTime today = DateTime.Today;
            FirebaseResponse res = await client.GetAsync("SESSION/");
            JObject jsonResponse = JObject.Parse(res.Body.ToString());

            List<JToken> filteredSessions = new List<JToken>();
            foreach (var session in jsonResponse.Children())
            {
                JToken startAtToken = session.First()["start_at"];
                if (startAtToken != null && startAtToken.ToObject<DateTime>().Date == today)
                {
                    filteredSessions.Add(session.First());
                }
            }

            int wins = 0;

            foreach (var session in filteredSessions)
            {
                if ((session["winner"].ToObject<int>() == 0 && session["redPawn"].ToString() == Program.UserID) ||
                    (session["winner"].ToObject<int>() == 1 && session["bluePawn"].ToString() == Program.UserID))
                {
                    wins++;
                }
            }

            if (wins == n)
            {
                return "Completed";
            }

            return "Not Completed";
        }
        private async void Mission_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < rewarded.Length; i++)
            {
                if (rewarded[i] != null && rewarded[i].Value.Date != DateTime.Today)
                {
                    rewarded = new DateTime?[10];
                    break;
                }
            }
            listView1.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem(daily[i]);
                listView1.Items.Add(item);
                ListViewItem.ListViewSubItem point = new ListViewItem.ListViewSubItem(item, daily_bonus[i].ToString());
                item.SubItems.Add(point);
                int number = int.Parse(daily[i].Split(' ')[1]);
                if (rewarded[i] != null)
                {
                    ListViewItem.ListViewSubItem status = new ListViewItem.ListViewSubItem(item, "Rewarded");
                    item.SubItems.Add(status);
                }
                else if (i < 5)
                {
                    ListViewItem.ListViewSubItem status = new ListViewItem.ListViewSubItem(item, await check_completed(number));
                    item.SubItems.Add(status);
                }
                else
                {
                    ListViewItem.ListViewSubItem status = new ListViewItem.ListViewSubItem(item, await check_wins(number));
                    item.SubItems.Add(status);
                }
            }
        }

        private async void claimBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem item = listView1.SelectedItems[0];
                if (item.SubItems[2].Text == "Completed")
                {
                    for (int i = 0; i < daily.Length; i++)
                    {
                        if (item.Text == daily[i])
                        {
                            rewarded[i] = DateTime.Now;
                        }
                    }

                    /*FirebaseResponse res = await client.GetAsync("USER/" + Program.UserID);
                    User data = res.ResultAs<User>();
                    data.score += int.Parse(item.SubItems[1].Text);
                    await client.SetAsync("USER/" + Program.UserID, data);*/
                    item.SubItems[2].Text = "Rewarded";
                    MessageBox.Show("Successfully received reward", "Claim successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (item.SubItems[2].Text == "Rewarded")
                {
                    MessageBox.Show("The reward has been received", "Claim unsuccessfully", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Have not completed the task", "Claim unsuccessfully", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

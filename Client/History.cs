using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Client
{
    public partial class History : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public History()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
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

        public async Task<int> getNumberOfLoses(string userID)
        {
            FirebaseResponse res = await client.GetAsync("SESSION/");
            Dictionary<string, Session> sessions = res.ResultAs<Dictionary<string, Session>>();
            int loses = 0;
            foreach (var sess in sessions.Values)
            {
                if ((sess.winner == 1 && sess.redPawn == userID) ||
                    (sess.winner == 0 && sess.bluePawn == userID))
                {
                    loses++;
                }
            }
            return loses;
        }
       
        public async Task<int> getNumberOfGames(string userID)
        {
            FirebaseResponse res = await client.GetAsync("SESSION/");
            Dictionary<string, Session> sessions = res.ResultAs<Dictionary<string, Session>>();
            int wins = 0;
            foreach (var sess in sessions.Values)
            {
                if ((sess.redPawn == userID) ||
                    (sess.bluePawn == userID))
                {
                    wins++;
                }
            }
            return wins;
        }
        private async void History_Load(object sender, EventArgs e)
        {
            label1.Text = Program.UserName;
            richTextBox4.Text = Program.UserRank.ToString();

            FirebaseResponse res = await client.GetAsync("SESSION/");
            dynamic IDs = res.ResultAs<dynamic>();
            listView1.Items.Clear();
            foreach (var id in IDs)
            {
                string sesionID = id.Name;
                FirebaseResponse sessionRes = await client.GetAsync("SESSION/" + sesionID);
                Session sessionData = sessionRes.ResultAs<Session>();
               /* string userID = sessionData.user_id[id];
                if (userID.ToString() == Program.UserID.ToString())
                {
                    ListViewItem item = null;
                    if (sessionData.result == 0)
                    {
                        item = new ListViewItem("Defeaut");
                    }
                    else
                    {
                        item = new ListViewItem("Victory");
                    }

                    if (sessionData.module_play == 0)
                    {
                        item.SubItems.Add("Single Player");
                    }
                    else
                    {
                        item.SubItems.Add("Multi PLayer");
                    }
                    item.SubItems.Add(sessionData.start_at.ToString());
                    item.SubItems.Add(sessionData.end_at.ToString());
                    listView1.Items.Add(item);*/
                }
            }
        }
    }


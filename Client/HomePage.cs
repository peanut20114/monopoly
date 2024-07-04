using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class HomePage : Form
    {
        string currName, currID;
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public HomePage(string userID, string userName)
        {
            currName = userName;
            currID = userID;
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu(currName, currID);
            menu.Show();
            this.Close();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Profile form = new Profile();
            form.Show();
        }

        private void btn_Friends_Click(object sender, EventArgs e)
        {
            Friends form = new Friends(currID);
            form.Show();
        }

        private void btn_Messages_Click(object sender, EventArgs e)
        {
            Event form = new Event();
            form.Show();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            /*History form = new History();
            form.Show();*/
        }

        private async void HomePage_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("", 200, HorizontalAlignment.Center);
            listView1.HeaderStyle = ColumnHeaderStyle.None;

            listView1.View = View.Details;
            listView1.Scrollable = false;

            FirebaseResponse res = await client.GetAsync("LEADERBOARD/");
            dynamic IDs = res.ResultAs<dynamic>();

            string[] leaderBoard = new string[7];

            foreach (var id in IDs)
            {
                string rankID = id.Name;
                FirebaseResponse rankRes = await client.GetAsync("LEADERBOARD/" + rankID);
                Leaderboard rankData = rankRes.ResultAs<Leaderboard>();
                string userID = rankData.user_id;
                int userRank = rankData.rank;
                int userScore = rankData.score;
                if (userID != null && userRank <= 7)
                {
                    FirebaseResponse userRes = await client.GetAsync("USER/" + userID);
                    User userdata = userRes.ResultAs<User>();
                    string userName = userdata.username;
                    leaderBoard[userRank - 1] = $"{userRank}. {userName} ({userScore} scores)";
                }
                if (userID == Program.UserID) {
                    Program.UserRank = userRank;
                }
            }

            foreach (string player in leaderBoard)
            {
                ListViewItem item = new ListViewItem("");
                listView1.Items.Add(item);
                ListViewItem.ListViewSubItem p = new ListViewItem.ListViewSubItem(item, player);
                item.SubItems.Add(p);
            }
        }
    }
}

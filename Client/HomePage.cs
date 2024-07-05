using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json.Linq;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Client
{
    public partial class HomePage : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public HomePage()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
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
            Friends form = new Friends();
            form.Show();
        }

        private void btn_Messages_Click(object sender, EventArgs e)
        {
            Mission form = new Mission();
            form.Show();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            History form = new History();
            form.Show();
        }

        private async void HomePage_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("", 200, HorizontalAlignment.Center);
            listView1.HeaderStyle = ColumnHeaderStyle.None;

            listView1.View = View.Details;
            listView1.Scrollable = false;

            FirebaseResponse res = await client.GetAsync("USER/");
            JObject jsonResponse = JObject.Parse(res.Body.ToString());

            string[] leaderBoard = new string[7];
            int topRank = 0;

            List<Tuple<string, int>> userList = new List<Tuple<string, int>>();

            foreach (var userToken in jsonResponse)
            {
                string userId = userToken.Key;
                JObject userData = (JObject)userToken.Value;

                int score = (int)userData["score"];

                userList.Add(new Tuple<string, int>(userId, score));
            }

            userList = userList.OrderByDescending(user => user.Item2).ToList();

            foreach (var user in userList)
            {
                if (topRank < 7)
                {
                    string userId = user.Item1;
                    JObject userData = (JObject)jsonResponse[userId];

                    string username = (string)userData["username"];

                    leaderBoard[topRank] = $"{topRank + 1}. {username} (Score: {user.Item2})";
                    topRank++;
                }

                if (user.Item1 == Program.UserID)
                {
                    Program.UserRank = userList.IndexOf(user) + 1;
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

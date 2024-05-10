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
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;


namespace Client
{
    public partial class Friends : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        public Friends()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private void LoadPlayerData()
        {
            string jsonFilePath = "D:\\UIT\\LapTrinhMang\\monopoly\\Fake_Database\\USER.json";
            if(File.Exists(jsonFilePath)) 
            {
                string jsonText = File.ReadAllText(jsonFilePath);
                players = JsonConvert.DeserializeObject<Dictionary<string, Player>>(jsonText);
            }
            else
            {
                MessageBox.Show("Player not found.");
                players = new Dictionary<string, Player>();
            }
        }

        private async  void button1_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("USER/");
            dynamic IDs = res.ResultAs<dynamic>();
            bool found = false;
            listView1.Items.Clear();
            foreach (var id in IDs)
            {
                string userID = id.Name;
                FirebaseResponse userRes = await client.GetAsync("USER/" + userID);
                User userdata = userRes.ResultAs<User>();
                string userName = userdata.username;
                string lastLoggedIn = userdata.last_logged_in;

                if (SearchBox.Text.ToLower() == userName.ToLower())
                {
                    found = true;
                    ListViewItem item = new ListViewItem(userName);
                    item.SubItems.Add(lastLoggedIn.ToString());
                    listView1.Items.Add(item);
                    break;
                }
            }
            if (!found)
            {
                MessageBox.Show("Player not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

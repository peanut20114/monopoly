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
                string userID = sessionData.user_id;
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
                    listView1.Items.Add(item);
                }
            }
        }
    }
}

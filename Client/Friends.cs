using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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
        string currID = null;
        public Friends(string userID)
        {
            currID = userID;
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        string userID = null;
        private async void SearchButton_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("USER/");
            dynamic IDs = res.ResultAs<dynamic>();
            bool found = false;
            listView1.Items.Clear();
            foreach (var id in IDs)
            {
                userID = id.Name;
                FirebaseResponse userRes = await client.GetAsync("USER/" + userID);
                User userdata = userRes.ResultAs<User>();
                string userName = userdata.username;
                string birthday = userdata.birthday;
                string country = userdata.country;
                string lastLoggedIn = userdata.last_logged_in;

                if (SearchBox.Text.Trim().ToLower() == userName.Trim().ToLower())
                {
                    found = true;
                    ListViewItem item = new ListViewItem(userName);
                    item.SubItems.Add(birthday.ToString());
                    item.SubItems.Add(country.ToString());
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

        private async void addFrBtn_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedPlayerName = listView1.SelectedItems[0].Text;

                FirebaseResponse currentUserRes = await client.GetAsync("USER/" + currID);
                User currUser = currentUserRes.ResultAs<User>();
                if (currUser != null)
                {
                    List<int> friendsList = currUser.friends.ToList();

                    int selectedUserID = int.Parse(userID);

                    if (!friendsList.Contains(selectedUserID))
                    {
                        friendsList.Add(selectedUserID);
                        currUser.friends = friendsList.ToArray();

                        FirebaseResponse updateRes = await client.SetAsync("USER/" + currID, currUser);


                        if (updateRes.StatusCode == System.Net.HttpStatusCode.OK)
                        {
                            MessageBox.Show($"You have added {listView1.SelectedItems[0].Text}", "Add Friend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error when adding friends.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This player has been your friend already.", "Add Friend", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Cannot find this player information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please choose one player to add!", "Add Friend", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

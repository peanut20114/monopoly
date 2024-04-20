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
        public HomePage()
        {
            InitializeComponent();
            LoadRankings();
        }

        private void btn_PlayGame_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }
        private void LoadRankings()
        {

            string[] players = new string[]
            {
                "John",
                "Emily",
                "Sarah",
                "Jessica",
                "Sophia",
                "James",
                "Olivia"
            };
            
            listView1.View = View.Details;
            listView1.Scrollable = false;

            listView1.Columns.Add("", 40, HorizontalAlignment.Center);
            listView1.Columns.Add("", 200, HorizontalAlignment.Center);
            listView1.HeaderStyle = ColumnHeaderStyle.None;

            Random random = new Random();

            foreach (string player in players)
            {
                int randomNumber = random.Next(15, 21);
                ListViewItem item = new ListViewItem("");
                listView1.Items.Add(item);
                ListViewItem.ListViewSubItem p = new ListViewItem.ListViewSubItem(item, $"{ player } ({ randomNumber } games)");
                item.SubItems.Add(p);
            }
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
            Event form = new Event();
            form.Show();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            History form = new History();
            form.Show();
        }
    }
}

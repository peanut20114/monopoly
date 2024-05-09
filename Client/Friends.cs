using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Remoting.Contexts;


namespace Client
{
    public partial class Friends : Form
    {

        public class Player
        {
            public string userName { get; set; }
            public string lastLoggedIn { get; set; }
        }

        private Dictionary<string, Player> players;
        public Friends()
        {
            InitializeComponent();
            LoadPlayerData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string search = richTextBox1.Text;
            List<Player> searchResults = players.Values.Where(u => u.userName == search).ToList();

            listView1.Items.Clear();

            foreach(var player in searchResults)
            {
                ListViewItem item = new ListViewItem(player.userName);
                item.SubItems.Add(player.lastLoggedIn);
                listView1.Items.Add(item);
            }
        }
    }
}

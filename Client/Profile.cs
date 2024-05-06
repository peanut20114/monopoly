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
    public partial class Profile : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public Profile()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private async void Profile_Load(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("USER/" + Program.UserID);
            User data = res.ResultAs<User>();
            richTextBox2.Text = data.UserName;
            richTextBox3.Text = data.Birthday;
            richTextBox4.Text = data.Country;
            richTextBox5.Text = data.Last_Logged_In;
        }
    }
}

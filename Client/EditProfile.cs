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

namespace Client
{
    public partial class EditProfile : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public EditProfile()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private static Dictionary<string, string> month2num = new Dictionary<string, string>()
        {
            {"January", "01"},
            {"February", "02"},
            {"March", "03"},
            {"April", "04"},
            {"May", "05"},
            {"June", "06"},
            {"July", "07"},
            {"August", "08"},
            {"September", "09"},
            {"October", "10"},
            {"November", "11"},
            {"December", "12"}
        };

        private static Dictionary<string, string> num2month = new Dictionary<string, string>()
        {
            {"01", "January"},
            {"02", "February"},
            {"03", "March"},
            {"04", "April"},
            {"05", "May"},
            {"06", "June"},
            {"07", "July"},
            {"08", "August"},
            {"09", "September"},
            {"10", "October"},
            {"11", "November"},
            {"12", "December"}
        };

        private void changePassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword form = new ChangePassword();
            form.Show();
        }

        private async void EditProfile_Load(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("USER/" + Program.UserID);
            User data = res.ResultAs<User>();
            nameBox.Text = data.username;
            string[] birthday = data.birthday.Split('/');
            dayBox.Text = birthday[0];
            monthBox.Text = num2month[birthday[1]];
            yearBox.Text = birthday[2];
            countryBox.Text = data.country;
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("USER/" + Program.UserID);
            User data = res.ResultAs<User>();
            data.username = nameBox.Text;
            data.birthday = dayBox.Text + "/" + month2num[monthBox.Text] + "/" + yearBox.Text;
            data.country = countryBox.Text;
            // Update the data in Firebase
            SetResponse updateResponse = await client.SetAsync("USER/" + Program.UserID, data);
            User updatedData = updateResponse.ResultAs<User>();
            // Close profile editor and open profile
            Profile prf = new Profile();
            prf.Show();
            this.Close();
        }
    }
}

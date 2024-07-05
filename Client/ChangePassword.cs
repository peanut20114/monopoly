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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ChangePassword : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };
        IFirebaseClient client;
        public ChangePassword()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }
        public static bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*\d)[a-zA-Z0-9!@#$%^&*()-+=]{8,16}$";
            return Regex.IsMatch(password, pattern);
        }

        private async void changeBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("USER/" + Program.UserID);
            User data = res.ResultAs<User>();
            if (data.password == oldPassBox.Text && IsValidPassword(newPassBox.Text) && newPassBox.Text == passAuthBox.Text) {
                data.password = newPassBox.Text;
                // Update the data in Firebase
                SetResponse updateResponse = await client.SetAsync("USER/" + Program.UserID, data);
                User updatedData = updateResponse.ResultAs<User>();
                // Close the form or open profile
                Profile prf = new Profile();
                prf.Show();
                this.Close();
            }
            else
            {
                if (data.password != oldPassBox.Text)
                {
                    errorOldPass.Text = "Old password not match";
                }
                if (!IsValidPassword(newPassBox.Text))
                {
                    errorNewPass.Text = "Invalid password";
                }
                if (newPassBox.Text != passAuthBox.Text)
                {
                    errorPassAuth.Text = "Please enter your password";
                }
            }
            
        }

        private void changePassword_Load_1(object sender, EventArgs e)
        {
            errorBox.Text = "Your password must:\n● Have between 8 and 16 characters.\n● Contain at least 1 number.";
        }

        private void oldPassBox_TextChanged(object sender, EventArgs e)
        {
            errorOldPass.Text = "";
        }

        private void newPassBox_TextChanged(object sender, EventArgs e)
        {
            errorNewPass.Text = "";
        }

        private void passAuthBox_TextChanged(object sender, EventArgs e)
        {
            errorPassAuth.Text = "";
        }
    }
}

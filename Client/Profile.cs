﻿using FireSharp.Config;
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
            nameLabel.Text = data.username;
            birthdayLabel.Text = data.birthday;
            countryLabel.Text = data.country;
            registerLabel.Text = data.register_at.ToString();
            introBox.Text = data.intro;
        }

        private void changePassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword form = new ChangePassword();
            form.Show();
            this.Close();
        }

        private void editProfileLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditProfile form = new EditProfile();
            form.Show();
            this.Close();
        }
    }
}
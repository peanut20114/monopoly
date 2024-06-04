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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class Register : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        public Register()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }
        private static Dictionary<string, string> monthMap = new Dictionary<string, string>()
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
        public static string GenerateRandomNumber()
        {
            Random random = new Random();
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < 9; i++)
            {
                stringBuilder.Append(random.Next(1, 10));
            }

            return stringBuilder.ToString();
        }
        public static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
        public static bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*\d)[a-zA-Z0-9!@#$%^&*()-+=]{8,16}$";
            return Regex.IsMatch(password, pattern);
        }
        private async void DoneButton_Click(object sender, EventArgs e)
        {
            if(UserNameTBox.Text.Length == 0)
            {
                Error.Text = "Username cannot be empty";
                return;
            }
            if(!IsValidEmail(EmailTBox.Text))
            {
                Error.Text = "Invalid email";
                return;
            }
            if(!IsValidPassword(PasswordTBox.Text) || PasswordTBox.Text == EmailTBox.Text)
            {
                Error.Text = "Invalid password";
                return;
            }
            var data = new User
            {
                username = UserNameTBox.Text,
                password = PasswordTBox.Text,
                birthday = comboBox1.Text + "/" + monthMap[comboBox2.Text] + "/" + comboBox3.Text,
                country = "Việt Nam",
                email = EmailTBox.Text,
                last_logged_in = DateTime.Now.ToString(),
                register_at = DateTime.Now.ToString(),
                friends = new int[0]
            };
            string ID = GenerateRandomNumber();
            SetResponse res = await client.SetAsync("USER/" + ID, data);
            User result = res.ResultAs<User>();
            MessageBox.Show("Account created successfully");
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            comboBox1.Text = "04";
            comboBox2.Text = "August";
            comboBox3.Text = "2004";
            richTextBox1.Text = "Your password must:\n● Have between 8 and 16 characters.\n● Contain at least 1 number.\n● Be different from your email address.";
        }
    }
}

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class ForgotPassword : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "RupkJmOpqVD7u65mZo31WEtDRqKWpkN2Oj6UtbNT",
            BasePath = "https://monopoly-8058b-default-rtdb.asia-southeast1.firebasedatabase.app/"
        };

        IFirebaseClient client;
        private int otpCode;
        public ForgotPassword()
        {
            client = new FireSharp.FirebaseClient(config);
            InitializeComponent();
        }

        private void SendMail(int code, string mailto)
        {
            string email = Environment.GetEnvironmentVariable("EMAIL_ADDRESS");
            string password = Environment.GetEnvironmentVariable("EMAIL_PASSWORD");

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            {
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(email, password);
                using (MailMessage message = new MailMessage())
                {
                    MailAddress fromAddress = new MailAddress(email);
                    message.From = fromAddress;
                    message.Subject = "Monopoly Board Game - Forgot Password";
                    message.IsBodyHtml = true;
                    message.To.Add(mailto);
                    message.Body = $"Your OTP code is {code}";

                    try
                    {
                        smtpClient.Send(message);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
        }

        private async void sendCodeBtn_Click(object sender, EventArgs e)
        {
            FirebaseResponse res = await client.GetAsync("USER/");
            dynamic IDs = res.ResultAs<dynamic>();
            bool emailExist = false;

            foreach (var id in IDs)
            {
                string userID = id.Name;
                FirebaseResponse userRes = await client.GetAsync("USER/" + userID);
                User userdata = userRes.ResultAs<User>();
                string Email = userdata.email;

                if (Email == emailBox.Text)
                {
                    emailExist = true;
                    break;
                }
            }
            if (emailExist)
            {
                otpCode = new Random().Next(1000, 10000);
                SendMail(otpCode, emailBox.Text);
            }
            else
            {
                errorEmail.Text = "Email does not exist";
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if(otpBox.Text == otpCode.ToString())
            {
                ChangePassword form = new ChangePassword();
                form.Show();
                this.Close();
            }
            else
            {
                errorOTP.Text = "OTP code not match";
            }
        }

        private void otpBox_TextChanged(object sender, EventArgs e)
        {
            errorOTP.Text = "";
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            errorEmail.Text = "";
        }
    }
}

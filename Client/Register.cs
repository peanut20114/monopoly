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
        private async void DoneButton_Click(object sender, EventArgs e)
        {
            var data = new User
            {
                UserName = UserNameButton.Text,
                Email = EmailButton.Text,
                Birthday = "03/04/2002",
                Password = richTextBox1.Text
            };
            string ID = GenerateRandomNumber();
            SetResponse res = await client.SetAsync("USER/" + ID, data);
            User result = res.ResultAs<User>();
            MessageBox.Show("Tạo tài khoản thành công");
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}

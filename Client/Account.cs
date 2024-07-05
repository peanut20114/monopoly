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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}

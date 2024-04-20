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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            HomePage menu = new HomePage();
            menu.Show();
            this.Close();
        }
    }
}

using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Client
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
            if (File.Exists("\\bin\\Release\\config.ini"))
            {
                ip_textbox.Text = File.ReadLines("\\bin\\Release\\config.ini").First();
                port_textbox.Text = File.ReadLines("\\bin\\Release\\config.ini").Skip(1).First();
            }
            else MessageBox.Show("Config file not found.");
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectionOptions.Port = Convert.ToInt32(port_textbox.Text);
            ConnectionOptions.IP = ip_textbox.Text;
            DialogResult = DialogResult.OK;
            Close();
        }
        private void returnBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

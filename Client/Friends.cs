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
    public partial class Friends : Form
    {
        public class Player
        {
            public string Username { get; set; }
            public string Email { get; set; }
        public Friends()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SearchTerm = listView1.Text;
        }
    }
}

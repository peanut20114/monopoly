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
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            listView1.View = View.Details;
            listView1.Scrollable = false;

            listView1.Columns.Add("Lastest Plays", 160, HorizontalAlignment.Center);
            listView1.Columns.Add("Result", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Total Time", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Total House", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Total Amount", 100, HorizontalAlignment.Center);

            for (int i = 0; i < 5; i++)
            {
                ListViewItem item = new ListViewItem(GetRandomDateTime(DateTime.Now, DateTime.Now.AddDays(14)).ToString("dd/MM/yyyy HH:mm:ss"));

                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, new Random().Next(2) == 0 ? "Win" : "Lose"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, GetRandomTimePlay()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, new Random().Next(5, 10).ToString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, new Random().Next(100000, 200000).ToString()));

                listView1.Items.Add(item);
            }
        }
        private string GetRandomTimePlay()
        {
            Random random = new Random();

            int randomMinutes = random.Next(0, 91);

            TimeSpan randomTime = TimeSpan.FromMinutes(randomMinutes);

            return randomTime.ToString(@"hh\:mm\:ss");
        }
        private DateTime GetRandomDateTime(DateTime from, DateTime to)
        {
            Random random = new Random();
            int range = (to - from).Days;
            return from.AddDays(random.Next(range));
        }

    }
}

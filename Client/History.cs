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

            listView1.Columns.Add("Lastest Plays", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Result", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Total Time", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Total House", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Total Amount", 100, HorizontalAlignment.Center);

            for (int i = 0; i < 5; i++)
            {
                ListViewItem item = new ListViewItem(GetRandomTimeStart());

                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, new Random().Next(2) == 0 ? "Win" : "Lose"));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, GetRandomTimePlay()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, new Random().Next(5, 10).ToString()));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, new Random().Next(100000, 200000).ToString()));

                listView1.Items.Add(item);
            }
        }
        private string GetRandomTimeStart()
        {
            Random random = new Random();

            TimeSpan startTime = new TimeSpan(9, 0, 0);
            TimeSpan endTime = new TimeSpan(20, 0, 0);

            int rangeMinutes = (int)(endTime - startTime).TotalMinutes;
            int randomMinutes = random.Next(rangeMinutes);
            TimeSpan randomTime = startTime.Add(TimeSpan.FromMinutes(randomMinutes));

            return randomTime.ToString(@"hh\:mm\:ss");
        }
        private string GetRandomTimePlay()
        {
            Random random = new Random();

            int randomMinutes = random.Next(0, 91);

            TimeSpan randomTime = TimeSpan.FromMinutes(randomMinutes);

            return randomTime.ToString(@"h\:mm\:ss");
        }

    }
}

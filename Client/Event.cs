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
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            listView1.View = View.Details;
            listView1.Scrollable = false;

            listView1.Columns.Add("Event", 210, HorizontalAlignment.Center);
            listView1.Columns.Add("Start At", 125, HorizontalAlignment.Center);
            listView1.Columns.Add("End At", 125, HorizontalAlignment.Center);
            listView1.Columns.Add("Status", 100, HorizontalAlignment.Center);

            for (int i = 0; i < 10; i++)
            {
                ListViewItem item = new ListViewItem($"Event_{i}");

                DateTime startTime = GetRandomDateTime(DateTime.Now, DateTime.Now.AddDays(7));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, startTime.ToString("dd/MM/yyyy HH:mm:ss")));

                DateTime endTime = startTime.AddDays(7);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, endTime.ToString("dd/MM/yyyy HH:mm:ss")));

                string eventStatus = GetEventStatus(startTime, endTime);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, eventStatus));

                listView1.Items.Add(item);
            }
        }
        private DateTime GetRandomDateTime(DateTime from, DateTime to)
        {
            Random random = new Random();
            int range = (to - from).Days;
            return from.AddDays(random.Next(range));
        }

        private string GetEventStatus(DateTime startTime, DateTime endTime)
        {
            DateTime now = DateTime.Now;
            if (now < startTime)
            {
                return "Up Coming";
            }
            else if (now >= startTime && now <= endTime)
            {
                return "On Going";
            }
            else
            {
                return "Finished";
            }
        }
    }
}

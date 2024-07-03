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
            listView1.FullRowSelect = true;


            // Add columns to the ListView.
            listView1.Columns.Add("Event", 210, HorizontalAlignment.Center);
            listView1.Columns.Add("Start At", 125, HorizontalAlignment.Center);
            listView1.Columns.Add("End At", 125, HorizontalAlignment.Center);
            listView1.Columns.Add("Status", 100, HorizontalAlignment.Center);
            string[] missions = { "Complete 1 Game", "Complete 2 Games", "Complete 3 Games", "Online 20 minutes", "Win 1 game", "Win 2 games", "Win 2 consecutive games" };
            for (int i = 0; i < 7; i++)
            {
                // Create a new ListViewItem with the event name.
                ListViewItem item = new ListViewItem($"{missions[i]}");

                // Generate random start and end times for the event.
                DateTime startTime = GetRandomDateTime(DateTime.Now, DateTime.Now.AddDays(7));
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, startTime.ToString("dd/MM/yyyy HH:mm:ss")));

                DateTime endTime = startTime.AddDays(7);
                item.SubItems.Add(new ListViewItem.ListViewSubItem(item, endTime.ToString("dd/MM/yyyy HH:mm:ss")));

                // Determine the event status and add it as a subitem.
                //string eventStatus = GetEventStatus(startTime, endTime);
                //ListViewItem.ListViewSubItem statusSubItem = new ListViewItem.ListViewSubItem(item, eventStatus);

                Random random = new Random();
                int randomNumber = random.Next(0, 2);
                string eventStatus = (randomNumber == 0) ? "Finished" : "Ongoing";
                ListViewItem.ListViewSubItem statusSubItem = new ListViewItem.ListViewSubItem(item, eventStatus);
                // Change the color based on the status.
                if (eventStatus == "Finished")
                {
                    statusSubItem.BackColor = Color.LightGreen; // Completed missions are highlighted in green.
                }
                else if (eventStatus == "Ongoing")
                {
                    statusSubItem.BackColor = Color.LightYellow; // Ongoing missions are highlighted in yellow.
                }
                else
                {
                    statusSubItem.BackColor = Color.LightCoral; // Future missions are highlighted in red.
                }

                item.SubItems.Add(statusSubItem);

                // Add the item to the ListView.
                listView1.Items.Add(item);
            }
        }
        string GetEventStatus(DateTime startTime, DateTime endTime)
        {
            DateTime now = DateTime.Now;
            if (now < startTime)
            {
                return "Upcoming";
            }
            else if (now >= startTime && now <= endTime)
            {
                return "Ongoing";
            }
            else
            {
                return "Finished";
            }
        }

        // Method to generate a random DateTime within a specified range.
        DateTime GetRandomDateTime(DateTime start, DateTime end)
        {
            Random rnd = new Random();
            int range = (end - start).Days;
            return start.AddDays(rnd.Next(range));
        }
        
    }
}

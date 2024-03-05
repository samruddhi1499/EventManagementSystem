using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class FormAdminViewEvent : Form
    {
        public static string selectedEvent { get; set; }
        public FormAdminViewEvent()
        {
            InitializeComponent();
        }

        private void FormAdminViewEvent_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = FormEventManipulation.eventObjectList;

            string[] arr = selectedEvent.Split('-');

            string a = arr[0].Trim();

            foreach (EventsClass array in arrayList)
            {

                EventsClass eventClass = (EventsClass)array;
                string b = eventClass.EventName.ToString();
                if (a.Equals(b))
                {
                    eventViewList.Items.Add("Event Name:  " + array.EventName.ToString());
                    eventViewList.Items.Add("Event Date:  " + array.EventDate.ToString());
                    eventViewList.Items.Add("Event Time:  " + array.EventTime.ToString());
                    eventViewList.Items.Add("Event Location:  " + array.EventLocation.ToString());
                    eventViewList.Items.Add("Event Description:  " + array.EventDescription.ToString());
                    eventViewList.Items.Add("Event Capacity:  " + array.EventCapacity.ToString());
                    eventViewList.Items.Add("Event Organizer:  " + array.EventEM.ToString());

                    break;

                }
            }

        }

        public void getVal(string val)
        {
            selectedEvent = val;
        }

        private void btnCloseView_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
        // Property to store the selected event
        public static string selectedEvent { get; set; }

        public FormAdminViewEvent()
        {
            InitializeComponent();
        }

        // Event handler for the form load event
        private void FormAdminViewEvent_Load(object sender, EventArgs e)
        {
            // Get the list of events from the FormEventManipulation class
            ArrayList arrayList = FormEventManipulation.eventObjectList;

            // Split the selected event to get its name
            string[] arr = selectedEvent.Split('-');
            string eventName = arr[0].Trim();

            // Iterate through the event list
            foreach (EventsClass array in arrayList)
            {
                // Check if the event name matches the selected event
                if (eventName.Equals(array.EventName))
                {
                    // Display event details in the list box
                    eventViewList.Items.Add("Event Name:  " + array.EventName);
                    eventViewList.Items.Add("Event Date:  " + array.EventDate);
                    eventViewList.Items.Add("Event Time:  " + array.EventTime);
                    eventViewList.Items.Add("Event Location:  " + array.EventLocation);
                    eventViewList.Items.Add("Event Description:  " + array.EventDescription);
                    eventViewList.Items.Add("Event Capacity:  " + array.EventCapacity);
                    eventViewList.Items.Add("Event Organizer:  " + array.EventEM);
                    break;
                }
            }
        }

        // Method to set the selected event
        public void getVal(string val)
        {
            selectedEvent = val;
        }

        // Event handler for clicking the close button
        private void btnCloseView_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }

        // Event handler for mouse hover on the close button
        private void btnCloseView_MouseHover(object sender, EventArgs e)
        {
            // Change button appearance on hover
            btnCloseView.BackColor = Color.MediumPurple;
            btnCloseView.ForeColor = Color.White;
        }

        // Event handler for mouse leaving the close button
        private void btnCloseView_MouseLeave(object sender, EventArgs e)
        {
            // Restore button appearance when mouse leaves
            btnCloseView.BackColor = Color.Gainsboro;
            btnCloseView.ForeColor = Color.Black;
        }
    }
}

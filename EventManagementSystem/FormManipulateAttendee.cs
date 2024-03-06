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
    public partial class FormManipulateAttendee : Form
    {
        ArrayList attendeeList = FormAttendeeHome.attendeeObjectList;
        public FormManipulateAttendee()
        {
            InitializeComponent();
            
            if (FormEventManipulation.eventObjectList.Count != 0)
            {
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    EventsClass eventClass = (EventsClass)val;
                    eventName.Items.Add(eventClass.EventName.ToString());
                }
                EventsClass eventClass1 = (EventsClass)FormEventManipulation.eventObjectList[0];
                eventName.Text = eventClass1.EventName.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void eventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (attendeeList.Count != 0)
            {


                foreach (Attendees attendees in attendeeList)
                {
                    if (eventName.SelectedItem.ToString() == attendees.EventName.ToString())
                        attendeeInfo.Items.Add(attendees.AttendeeName);
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            Attendees newAttendee = new Attendees(eventName.SelectedItem.ToString(), attendeeName.Text);
            attendeeList.Add(newAttendee);
            MessageBox.Show("Attendee Added ", "Adding Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            attendeeInfo.Items.Add(attendeeName.Text);

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool deleted = false;
            foreach (Attendees attendees in attendeeList)
            {
                
                if (attendees.AttendeeName.ToString() == attendeeName.Text && attendees.EventName.ToString() == eventName.Text) {
                    attendeeList.RemoveAt(count);
                    attendeeInfo.Items.Remove(attendeeName.Text);
                    deleted = true;
                    break;
                }
                count++;

            }
            if(deleted) {
                MessageBox.Show("Attendee Deleted", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Attendee not present", "Invalid attendee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

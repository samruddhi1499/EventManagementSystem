using Microsoft.Win32;
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
            foreach (EventsClass val in FormEventManipulation.eventObjectList)
            {
                if (eventName.SelectedItem.ToString() == val.EventName.ToString())
                {
                    if (val.EventCapacity == 0)
                    {
                        MessageBox.Show("Sorry, the event is fully booked.", "Capacity Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        val.EventCapacity -= 1;
                        MessageBox.Show("Attendee Added ", "Adding Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        attendeeInfo.Items.Add(attendeeName.Text);
                    }

                }
            }
            

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool deleted = false;
            foreach (Attendees attendees in attendeeList)
            {

                if (attendees.AttendeeName.ToString() == attendeeName.Text && attendees.EventName.ToString() == eventName.Text)
                {
                    attendeeList.RemoveAt(count);
                    attendeeInfo.Items.Remove(attendeeName.Text);
                    deleted = true;
                    break;
                }
                count++;

            }
            if (deleted)
            {
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (eventName.SelectedItem.ToString() == val.EventName.ToString())
                    {
                        val.EventCapacity += 1;
                        MessageBox.Show("Attendee Deleted", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Attendee not present", "Invalid attendee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void add_MouseHover(object sender, EventArgs e)
        {
            add.BackColor = Color.MediumPurple;
            add.ForeColor = Color.White;
        }

        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = Color.Gainsboro; ;
            add.ForeColor = Color.Black;
        }

        private void delete_MouseHover(object sender, EventArgs e)
        {
            delete.BackColor = Color.MediumPurple;
            delete.ForeColor = Color.White;
        }

        private void delete_MouseLeave(object sender, EventArgs e)
        {
            delete.BackColor = Color.Gainsboro; ;
            delete.ForeColor = Color.Black;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumPurple;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gainsboro; ;
            button1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

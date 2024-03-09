using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class FormAttendeeHome : Form
    {


        public static ArrayList eventNames = new ArrayList();
        public static ArrayList attendeeObjectList = new ArrayList();

        public static string eventName;
        public static string registeredEventName;
        BindingSource bs = new BindingSource();

        public FormAttendeeHome()
        {
            InitializeComponent();
            //if (FormEventManipulation.eventObjectList.Count == 0)
            //{
            //    MessageBox.Show("No Events in List", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            if (FormEventManipulation.eventObjectList.Count != 0)
            {
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    EventsClass eventClass = (EventsClass)val;
                    listEvents.Items.Add(eventClass.EventName.ToString());
                }
                EventsClass eventClass1 = (EventsClass)FormEventManipulation.eventObjectList[0];
                listEvents.Text = eventClass1.EventName.ToString();
            }



        }

        public void getRegisteredEvent(string EventName)
        {



            registeredEventName = EventName;

        }

        public void addAttendee(string eventName, string attendeeName, string phone, string emailid, string studentno)
        {

            Attendees attendees = new Attendees(eventName, attendeeName, phone, emailid, studentno);
            attendeeObjectList.Add(attendees);

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void viewEvent_Click(object sender, EventArgs e)
        {

            if (FormEventManipulation.eventObjectList.Count == 0)
            {
                MessageBox.Show("No items in list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (listEvents.SelectedItem.ToString() == val.EventName.ToString())
                    {
                        string eventName = $"Event Name: {val.EventName}";
                        string eventDate = $"Event Date: {val.EventDate}";
                        string eventDesc = $"Event Description: {val.EventDescription}";
                        string eventTime = $"Event Time: {val.EventTime}";
                        string eventLoc = $"Event Location: {val.EventLocation}";
                        string eventCap = $"Event Capacity: {val.EventCapacity}";
                        string eventEm = $"Event Manager: {val.EventEM}";
                        string[] events = { eventName, eventDate, eventDesc, eventTime, eventLoc, eventCap, eventEm };
                        foreach (string details in events)
                        {
                            listEventDetails.Items.Add(details);
                        }
                    }
                }
            }
        }

        private void register_Click(object sender, EventArgs e)
        {
            //foreach (EventsClass val in eventObjectList)
            //{
            //    if (listEvents.SelectedItem.ToString() == val.EventName.ToString())
            //    {
            //        eventName = val.EventName.ToString();

            //    }
            //}
            if (FormEventManipulation.eventObjectList.Count == 0)
            {
                MessageBox.Show("No items in list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eventName = listEvents.SelectedItem.ToString();
                FormRegister register = new FormRegister();
                register.ShowDialog();
            }
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (eventNames.Count == 0)
            {
                MessageBox.Show("No items in list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (regiterEvents.SelectedItem.ToString() == val.EventName.ToString())
                    {
                        string eventName = $"Event Name: {val.EventName}";
                        string eventDate = $"Event Date: {val.EventDate}";
                        string eventDesc = $"Event Description: {val.EventDescription}";
                        string eventTime = $"Event Time: {val.EventTime}";
                        string eventLoc = $"Event Location: {val.EventLocation}";
                        string eventCap = $"Event Capacity: {val.EventCapacity}";
                        string eventEm = $"Event Manager: {val.EventEM}";
                        string[] events = { eventName, eventDate, eventDesc, eventTime, eventLoc, eventCap, eventEm };
                        foreach (string details in events)
                        {
                            listEventDetails.Items.Add(details);
                        }
                    }
                }
            }


        }

        private void FormAttendeeHome_Activated(object sender, EventArgs e)
        {
            listEventDetails.Items.Clear();
            if (registeredEventName != null)
            {
                eventNames.Add(eventName);
                foreach (string name in eventNames)
                {
                    regiterEvents.Items.Add(name);
                }
                if (eventNames.Count == 1)
                {
                    regiterEvents.Text = eventNames[0].ToString();
                }
            }

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }
    }
}

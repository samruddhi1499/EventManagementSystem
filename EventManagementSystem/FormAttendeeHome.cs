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

        public static ArrayList eventObjectList = new ArrayList();
        public static ArrayList eventNames = new ArrayList();
        
        EventsClass eventsClass = new EventsClass("IT", "12 March", "2.30", "Humber", "Tech", 3, "sam");
        public static string eventName;
        public static string registeredEventName;
        BindingSource bs = new BindingSource();

        public FormAttendeeHome()
        {
            InitializeComponent();
            if (eventObjectList.Count == 0)
            {
                eventObjectList.Add(eventsClass);
            }

            foreach (EventsClass val in eventObjectList)
            {
                EventsClass eventClass = (EventsClass)val;
                listEvents.Items.Add(eventClass.EventName.ToString());
            }
            EventsClass eventClass1 = (EventsClass)eventObjectList[0];
            listEvents.Text = eventClass1.EventName.ToString();


        }

        public void getRegisteredEvent(string EventName)
        {



            registeredEventName = EventName;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            eventObjectList.Add(eventsClass);

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = listEvents.SelectedItem.ToString();
        }

        
        private void viewEvent_Click(object sender, EventArgs e)
        {
            foreach (EventsClass val in eventObjectList)
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

        private void register_Click(object sender, EventArgs e)
        {
            //foreach (EventsClass val in eventObjectList)
            //{
            //    if (listEvents.SelectedItem.ToString() == val.EventName.ToString())
            //    {
            //        eventName = val.EventName.ToString();

            //    }
            //}

            eventName = listEvents.SelectedItem.ToString();
            FormRegister register = new FormRegister();
            register.ShowDialog();
        }

        private void View_Click(object sender, EventArgs e)
        {
            foreach (EventsClass val in eventObjectList)
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

        private void FormAttendeeHome_Activated(object sender, EventArgs e)
        {
            
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
    }
}

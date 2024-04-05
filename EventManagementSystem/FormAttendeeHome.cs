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
using MySqlConnector; // Import MySQL Connector for database operations

namespace EventManagementSystem
{
    public partial class FormAttendeeHome : Form
    {
        // Define variables to store event names and attendee objects
        public static ArrayList eventNames = new ArrayList();
        public static ArrayList attendeeObjectList = new ArrayList();
        public static string Username;

        public static string eventName;
        public static string registeredEventName;

        public FormAttendeeHome()
        {
            InitializeComponent();
            // Initialize form components when the form is loaded
            if (FormEventManipulation.eventObjectList.Count != 0)
            {
                // Populate listEvents ListBox with event names
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    EventsClass eventClass = (EventsClass)val;
                    listEvents.Items.Add(eventClass.EventName.ToString());
                }
                // Select the first event by default
                EventsClass eventClass1 = (EventsClass)FormEventManipulation.eventObjectList[0];
                listEvents.Text = eventClass1.EventName.ToString();
            }
        }

        // Method to set the username
        public void GetUsername(string username)
        {
            Username = username;
        }

        // Method to set the registered event name
        public void getRegisteredEvent(string EventName)
        {
            registeredEventName = EventName;
        }

        // Method to add attendee to an event
        public void addAttendee(string eventName, string username, string attendeeName, string phone, string emailid, string studentno)
        {
            try
            {
                FormMain.mySqlConnection.Open();
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (FormAttendeeHome.eventName == val.EventName.ToString())
                    {
                        // Update event capacity in the database
                        string updateCapacity = $"UPDATE event SET event_capacity = {val.EventCapacity - 1} WHERE event_name = \"{FormAttendeeHome.eventName}\"";
                        val.EventCapacity -= 1;
                        MySqlCommand mySqlUpdateCommand = new MySqlCommand(updateCapacity, FormMain.mySqlConnection);
                        mySqlUpdateCommand.ExecuteNonQuery();
                        // Insert attendee registration details into the database
                        string insertCmd = $"INSERT INTO attendeeregistration VALUES (\"{eventName}\", \"{username}\", \"{attendeeName}\", \"{phone}\", \"{emailid}\", \"{studentno}\")";
                        MySqlCommand mySqlInsertCommand = new MySqlCommand(insertCmd, FormMain.mySqlConnection);
                        mySqlInsertCommand.ExecuteNonQuery();
                        // Add attendee object to the list
                        Attendees attendees = new Attendees(eventName, username, attendeeName, phone, emailid, studentno);
                        attendeeObjectList.Add(attendees);
                        eventNames.Add(eventName);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
            }
        }

        // Method to load all attendees from the database
        public void LoadAllAttendee()
        {
            try
            {
                // Get all attendees from the database
                FormMain.mySqlConnection.Open();
                string selectLoadSQL = "SELECT * FROM attendeeregistration";
                MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string eventName = dataReader["event_name"] + "";
                    string username = dataReader["username"] + "";
                    string attendeeName = dataReader["attendee_name"] + "";
                    string attendeePhone = dataReader["attendee_phone"] + "";
                    string attendeeEmail = dataReader["attendee_email"] + "";
                    string attendeeStudentNo = dataReader["attendee_student_no"] + "";

                    // Create and add attendee object to the list
                    Attendees attendees = new Attendees(eventName, username, attendeeName, attendeePhone, attendeeEmail, attendeeStudentNo);
                    attendeeObjectList.Add(attendees);
                }
            }
            // Show any error
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
            }
        }

        // Method to view event details
        private void viewEvent_Click(object sender, EventArgs e)
        {
            // Check if there are events in the list
            if (FormEventManipulation.eventObjectList.Count == 0)
            {
                MessageBox.Show("No items in list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Show all event details of the event
                listEventDetails.Items.Clear();
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (listEvents.SelectedItem.ToString() == val.EventName.ToString())
                    {
                        // Display event details in listEventDetails ListBox
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

        // Method to handle registration button click
        private void register_Click(object sender, EventArgs e)
        {
            if (FormEventManipulation.eventObjectList.Count == 0)
            {
                MessageBox.Show("No items in list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eventName = listEvents.SelectedItem.ToString();
                // Check if the user has registered before
                bool registeredBefore = false;
                foreach (Attendees atn in attendeeObjectList)
                {
                    if (eventName.Equals(atn.EventName) && Username.Equals(atn.Username))
                    {
                        registeredBefore = true;
                    }
                }
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (eventName == val.EventName.ToString())
                    {
                        // Check if the event capacity is full
                        if (val.EventCapacity == 0)
                        {
                            MessageBox.Show("Sorry, the event is fully booked.", "Capacity Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (registeredBefore)
                        {
                            MessageBox.Show(" This user has already registered for this event", "Already registered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Open registration form
                            FormRegister register = new FormRegister();
                            register.ShowDialog();
                        }
                    }
                }
            }
        }

        // Method to view registered events
        private void View_Click(object sender, EventArgs e)
        {
            // If there is no events
            if (eventNames.Count == 0)
            {
                MessageBox.Show("No items in list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // List the registered event details
                listEventDetails.Items.Clear();
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (regiterEvents.SelectedItem.ToString() == val.EventName.ToString())
                    {
                        // Display event details in listEventDetails ListBox
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

        // Method to load registered events when the form is activated
        private void FormAttendeeHome_Activated(object sender, EventArgs e)
        {
            listEventDetails.Items.Clear();
            regiterEvents.Items.Clear();
            // Load the registered event 
            eventNames.Clear();
                loadRegisteredEvents();
            
                // Add the events 
                foreach (string name in eventNames)
                {
                    regiterEvents.Items.Add(name);
                }
                if (eventNames.Count == 1)
                {
                    regiterEvents.Text = eventNames[0].ToString();
                }
            
        }

        // Method to load registered events from the database
        public void loadRegisteredEvents()
        {
            try
            {
                // Get events from database
                FormMain.mySqlConnection.Open();
                string selectLoadSQL = $"SELECT * FROM attendeeregistration WHERE username = \"{Username}\"";
                MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        // Add the events in the array
                        string eventName = dataReader["event_name"] + "";
                        eventNames.Add(eventName);
                    }
                }
            }
            // Show error message
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
            }
        }

        // Method to handle logout menu item click
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        // Method to handle edit profile menu item click
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        // Methods to handle button hover events
        private void viewEvent_MouseHover(object sender, EventArgs e)
        {
            viewEvent.BackColor = Color.MediumPurple;
            viewEvent.ForeColor = Color.White;
        }

        private void viewEvent_MouseLeave_1(object sender, EventArgs e)
        {
            viewEvent.BackColor = Color.Gainsboro;
            viewEvent.ForeColor = Color.Black;
        }

        private void register_MouseHover_1(object sender, EventArgs e)
        {
            register.BackColor = Color.MediumPurple;
            register.ForeColor = Color.White;
        }

        private void register_MouseLeave_1(object sender, EventArgs e)
        {
            register.BackColor = Color.Gainsboro;
            register.ForeColor = Color.Black;
        }

        private void View_MouseHover(object sender, EventArgs e)
        {
            View.BackColor = Color.MediumPurple;
            View.ForeColor = Color.White;
        }

        private void View_MouseLeave(object sender, EventArgs e)
        {
            View.BackColor = Color.Gainsboro;
            View.ForeColor = Color.Black;
        }
    }
}

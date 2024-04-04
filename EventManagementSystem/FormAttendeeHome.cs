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
using MySqlConnector;


namespace EventManagementSystem
{
    public partial class FormAttendeeHome : Form
    {


        public static ArrayList eventNames = new ArrayList();
        public static ArrayList attendeeObjectList = new ArrayList();
        public static string Username;

        public static string eventName;
        public static string registeredEventName;

        public FormAttendeeHome()
        {
            InitializeComponent();

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

        public void GetUsername(string username)
        {
            this.Username = username;
        }


        public void getRegisteredEvent(string EventName)
        {

            registeredEventName = EventName;

        }

        public void addAttendee(string eventName, string username, string attendeeName, string phone, string emailid, string studentno)
        {

            try
            {
                FormMain.mySqlConnection.Open();
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (FormAttendeeHome.eventName == val.EventName.ToString())
                    {
                        
                        string updateCapacity = $"UPDATE event SET event_capacity = {val.EventCapacity - 1} WHERE event_name = \"{FormAttendeeHome.eventName}\"";
                        val.EventCapacity -= 1;
                        MySqlCommand mySqlUpdateCommand = new MySqlCommand(updateCapacity, FormMain.mySqlConnection);
                        mySqlUpdateCommand.ExecuteNonQuery();
                        string insertCmd = $"INSERT INTO attendeeregistration VALUES (\"{eventName}\", \"{username}\", \"{attendeeName}\", \"{phone}\", \"{emailid}\", \"{studentno}\")";
                        MySqlCommand mySqlInsertCommand = new MySqlCommand(insertCmd, FormMain.mySqlConnection);
                        mySqlInsertCommand.ExecuteNonQuery();
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

        public void LoadAllAttendee()
        {
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

                Attendees attendees = new Attendees(eventName, username, attendeeName, attendeePhone, attendeeEmail, attendeeStudentNo);
                attendeeObjectList.Add(attendees);

            }

            FormMain.mySqlConnection.Close();
        }


        private void viewEvent_Click(object sender, EventArgs e)
        {

            if (FormEventManipulation.eventObjectList.Count == 0)
            {
                MessageBox.Show("No items in list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                listEventDetails.Items.Clear();
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

            if (FormEventManipulation.eventObjectList.Count == 0)
            {
                MessageBox.Show("No items in list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                eventName = listEvents.SelectedItem.ToString();

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
                        if (val.EventCapacity == 0)
                        {
                            MessageBox.Show("Sorry, the event is fully booked.", "Capacity Full", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        } else if (registeredBefore)
                        {
                            MessageBox.Show(" This user has already registered for this event", "Already registered", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            FormRegister register = new FormRegister();
                            register.ShowDialog();
                        }
                    }
                }

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
                listEventDetails.Items.Clear();
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
            regiterEvents.Items.Clear();

            if (eventNames.Count == 0)
            {
                loadRegisteredEvents();

            }
            else if (eventNames.Count > 0)
            {
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

        public void loadRegisteredEvents()
        {
            FormMain.mySqlConnection.Open();
            string selectLoadSQL = "SELECT * FROM attendeeregistration WHERE username = \"Attendee1\"";
            MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    string eventName = dataReader["event_name"] + "";
                    eventNames.Add(eventName);
                }
            }
            FormMain.mySqlConnection.Close();
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

        private void viewEvent_MouseHover(object sender, EventArgs e)
        {
            viewEvent.BackColor = Color.MediumPurple;
            viewEvent.ForeColor = Color.White;
        }

        private void viewEvent_MouseLeave_1(object sender, EventArgs e)
        {
            viewEvent.BackColor = Color.Gainsboro; ;
            viewEvent.ForeColor = Color.Black;
        }

        private void register_MouseHover_1(object sender, EventArgs e)
        {
            register.BackColor = Color.MediumPurple;
            register.ForeColor = Color.White;
        }

        private void register_MouseLeave_1(object sender, EventArgs e)
        {
            register.BackColor = Color.Gainsboro; ;
            register.ForeColor = Color.Black;
        }

        private void View_MouseHover(object sender, EventArgs e)
        {
            View.BackColor = Color.MediumPurple;
            View.ForeColor = Color.White;
        }

        private void View_MouseLeave(object sender, EventArgs e)
        {
            View.BackColor = Color.Gainsboro; ;
            View.ForeColor = Color.Black;
        }

   
    }
}

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
using static System.Runtime.InteropServices.JavaScript.JSType;
using MySqlConnector;
using System.Data;
using static Mysqlx.Datatypes.Scalar.Types;
using System.Data.Common;

namespace EventManagementSystem
{
    public partial class FormEventManipulation : Form
    {
        // ArrayList to hold event objects
        public static ArrayList eventObjectList = new ArrayList();

        // ArrayList to hold event names
        static ArrayList eventNames = new ArrayList();

        // ArrayList to hold event managers
        public static ArrayList eventManager = new ArrayList();

        BindingSource bs = new BindingSource();

        // Constructor
        public FormEventManipulation()
        {
            InitializeComponent();
        }

        // Method to receive data for adding events
        public void receiveData(string eventName, string eventDate, string eventTime, int eventCapacity, string eventLoc, string eventDes, string em)
        {
            // Create an EventsClass object and add it to the eventObjectList
            EventsClass eventsClass = new EventsClass(eventName, eventDate, eventTime, eventLoc, eventDes, eventCapacity, em);
            eventObjectList.Add(eventsClass);
            string txt = eventName + " - " + em;
            eventNames.Add(txt);
        }

        // Method to receive data for editing events
        public void receiveDataEdit(string eventName, string eventDate, string eventTime, int eventCapacity, string eventLoc, string eventDes, string em)
        {
            // Update the event details in eventObjectList and eventNames
            foreach (EventsClass val in eventObjectList)
            {
                if (val.EventName == eventName)
                {
                    val.EventEM = em;
                    val.EventTime = eventTime;
                    val.EventDate = eventDate;
                    val.EventDescription = eventDes;
                    val.EventLocation = eventLoc;
                    val.EventCapacity = eventCapacity;
                    break;
                }
            }
            foreach (string val in eventNames)
            {
                if (val.Contains(eventName))
                {
                    string txt = eventName + " - " + em;
                    int myIndex = eventNames.IndexOf(val);
                    eventNames.RemoveAt(myIndex);
                    eventNames.Add(txt);
                    break;
                }
            }
        }

        // Method to receive data for deleting events
        public void receiveDataDelete(string eventName)
        {
            // Remove the event from eventObjectList and eventNames
            foreach (EventsClass val in eventObjectList)
            {
                if (val.EventName == eventName)
                {
                    eventObjectList.Remove(val);
                    break;
                }
            }
            foreach (string val in eventNames)
            {
                if (val.Contains(eventName))
                {
                    eventNames.Remove(val);
                    break;
                }
            }
        }

        // Event handler for adding a new event
        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            FormEventAdd formEventAdd = new FormEventAdd();
            formEventAdd.ShowDialog();
        }

        // Event handler for form load event
        private void FormEventManipulation_Load(object sender, EventArgs e)
        {
            try
            {
                // Load event names into the binding source
                bs.DataSource = eventNames;
                eventList.DataSource = bs;
            }
            catch (Exception ex)
            {

            }
        }

        // Method to load all events from the database
        public void LoadAll()
        {
            try
            {
                // Open database connection
                FormMain.mySqlConnection.Open();
                string selectLoadSQL = "select * from event";
                MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    // Read event details from the database
                    string eventName = dataReader["event_name"] + "";
                    string eventDate = dataReader["event_date"] + "";
                    string eventTime = dataReader["event_time"] + "";
                    string eventLocation = dataReader["event_loaction"] + "";
                    string eventDes = dataReader["event_description"] + "";
                    string em = dataReader["event_manager"] + "";
                    int capacity = Convert.ToInt32(dataReader["event_capacity"]);

                    // Create an EventsClass object and add it to eventObjectList
                    EventsClass events = new EventsClass(eventName, eventDate, eventTime, eventLocation, eventDes, capacity, em);
                    eventObjectList.Add(events);

                }
                foreach (EventsClass array in eventObjectList)
                {
                    EventsClass eventClass = (EventsClass)array;
                    eventNames.Add(eventClass.EventName + " - " + eventClass.EventEM);
                }

            }
            catch (MySqlException e)
            {

                MessageBox.Show("Database Error", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close database connection
                FormMain.mySqlConnection.Close();
            }

        }

        // Method to load all event managers from the database
        public void LoadAllEM()
        {
            try
            {
                FormMain.mySqlConnection.Open();
                eventManager.Clear();
                string selectLoadEMSQL = $"select username from user where role = 'EM'";
                MySqlCommand mySqlCommand = new MySqlCommand(selectLoadEMSQL, FormMain.mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    string eventEM = dataReader["username"] + "";
                    eventManager.Add(eventEM);

                }

            }
            catch (MySqlException e)
            {

                MessageBox.Show("Database Error", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Event handler for form activation event
        private void FormEventManipulation_Activated(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
        }

        // Event handler for editing an event
        private void btnEventEdit_Click(object sender, EventArgs e)
        {
            if (eventList.Items.Count == 0)
            {
                MessageBox.Show("No Events in List", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormEventEdit formEventEdit = new FormEventEdit();
                formEventEdit.ShowDialog();
            }
        }

        // Event handler for deleting an event
        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            if (eventList.Items.Count == 0)
            {
                MessageBox.Show("No Events in List", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormEventDelete formEventDelete = new FormEventDelete();
                formEventDelete.ShowDialog();
            }
        }

        // Event handler for logging out
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        // Event handler for navigating to home
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminHome home = new FormAdminHome();
            this.Close();
            home.Show();
        }

        // Event handler for viewing an event
        private void btnEventView_Click(object sender, EventArgs e)
        {
            if (eventList.Items.Count == 0)
            {
                MessageBox.Show("No Events in List", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FormAdminViewEvent formAdminViewEvent = new FormAdminViewEvent();
                formAdminViewEvent.getVal(eventList.SelectedItem.ToString());
                formAdminViewEvent.ShowDialog();
            }
        }

        // Event handler for editing profile
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        // Event handlers for hover effects on buttons
        private void btnEventAdd_MouseHover(object sender, EventArgs e)
        {
            btnEventAdd.BackColor = Color.MediumPurple;
            btnEventAdd.ForeColor = Color.White;
        }

        private void btnEventAdd_MouseLeave(object sender, EventArgs e)
        {
            btnEventAdd.BackColor = Color.Gainsboro;
            btnEventAdd.ForeColor = Color.Black;
        }

        private void btnEventEdit_MouseHover(object sender, EventArgs e)
        {
            btnEventEdit.BackColor = Color.MediumPurple;
            btnEventEdit.ForeColor = Color.White;
        }

        private void btnEventEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEventEdit.BackColor = Color.Gainsboro;
            btnEventEdit.ForeColor = Color.Black;
        }

        private void btnEventDelete_MouseHover(object sender, EventArgs e)
        {
            btnEventDelete.BackColor = Color.MediumPurple;
            btnEventDelete.ForeColor = Color.White;
        }

        private void btnEventDelete_MouseLeave(object sender, EventArgs e)
        {
            btnEventDelete.BackColor = Color.Gainsboro;
            btnEventDelete.ForeColor = Color.Black;
        }

        private void btnEventView_MouseHover(object sender, EventArgs e)
        {
            btnEventView.BackColor = Color.MediumPurple;
            btnEventView.ForeColor = Color.White;
        }

        private void btnEventView_MouseLeave(object sender, EventArgs e)
        {
            btnEventView.BackColor = Color.Gainsboro;
            btnEventView.ForeColor = Color.Black;
        }
    }
}

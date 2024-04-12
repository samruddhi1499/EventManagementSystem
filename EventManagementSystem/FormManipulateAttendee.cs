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
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class FormManipulateAttendee : Form
    {
        // ArrayList to store attendee objects
        ArrayList attendeeList = FormAttendeeHome.attendeeObjectList;

        public static string RoleHome;
        public static string UserHome;

        public FormManipulateAttendee()
        {
            InitializeComponent();

            // Populate event names in the eventName ComboBox
            if (FormEventManipulation.eventObjectList.Count != 0)
            {
                if (RoleHome == "EM")
                {
                    int count = 0;
                    foreach (EventsClass val in FormEventManipulation.eventObjectList)
                    {
                        EventsClass eventClass = (EventsClass)val;
                        if (eventClass.EventEM == UserHome)
                        {
                            eventName.Items.Add(eventClass.EventName.ToString());
                            eventName.Text = eventClass.EventName.ToString();
                        }
                            

                    }
                 
                }
                else
                {
                    foreach (EventsClass val in FormEventManipulation.eventObjectList)
                    {
                        EventsClass eventClass = (EventsClass)val;
                        eventName.Items.Add(eventClass.EventName.ToString());
                    }
                    // Set the default selected event name
                    EventsClass eventClass1 = (EventsClass)FormEventManipulation.eventObjectList[0];
                    eventName.Text = eventClass1.EventName.ToString();
                }

            }
        }

        // Event handler for eventName ComboBox selection change
        private void eventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Clear the attendeeInfo and username ComboBoxes
                attendeeInfo.Items.Clear();
                username.Items.Clear();

                // Open MySQL connection
                FormMain.mySqlConnection.Open();
                // SQL command to select all users
                string selectLoadSQL = "SELECT * FROM user";
                MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
                MySqlDataReader dataReader = mySqlCommand.ExecuteReader();

                // Add header to attendeeInfo
                attendeeInfo.Items.Add("Attendee Name\tUsername\n");

                // Loop through each attendee and check if they are registered for the selected event
                if (attendeeList.Count > 0)
                {
                    foreach (Attendees attendees in attendeeList)
                    {
                        while (dataReader.Read())
                        {
                            if (dataReader["username"].ToString() != "admin")
                            {
                                if (eventName.SelectedItem.ToString().Equals(attendees.EventName) && !dataReader["username"].Equals(attendees.Username))
                                {
                                    username.Items.Add(dataReader["username"]);
                                }
                                else if (!eventName.SelectedItem.ToString().Equals(attendees.EventName))
                                {
                                    username.Items.Add(dataReader["username"]);
                                }
                            }
                        }
                        // Display attendee information for the selected event
                        if (eventName.SelectedItem.ToString() == attendees.EventName.ToString())
                            attendeeInfo.Items.Add($"{attendees.AttendeeName}\t{attendees.Username}");
                    }
                }
                // If there are no attendees registered for any event
                else if (attendeeList.Count == 0)
                {
                    // Display all usernames
                    while (dataReader.Read())
                        username.Items.Add(dataReader["username"]);
                }
            } // Show any error
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
                // Close MySQL connection
                FormMain.mySqlConnection.Close();
            }


        }

        // Event handler for adding an attendee to an event
        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                // Open MySQL connection
                FormMain.mySqlConnection.Open();

                // SQL command to insert attendee registration into the database
                string selectLoadSQL = $"INSERT INTO attendeeregistration (event_name, username, attendee_name) VALUES (\"{eventName.SelectedItem.ToString()}\", \"{username.SelectedItem.ToString()}\", \"{attendeeName.Text}\")";
                MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
                mySqlCommand.ExecuteNonQuery();

                // Create new Attendees object for the new attendee
                Attendees newAttendee = new Attendees(eventName.SelectedItem.ToString(), username.SelectedItem.ToString(), attendeeName.Text);
                attendeeList.Add(newAttendee);

                // Update event capacity
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
                            string updateCapacity = $"UPDATE event SET event_capacity = {val.EventCapacity - 1} WHERE event_name = \"{eventName.SelectedItem.ToString()}\"";
                            MySqlCommand mySqlUpdateCommand = new MySqlCommand(updateCapacity, FormMain.mySqlConnection);
                            mySqlUpdateCommand.ExecuteNonQuery();

                            MessageBox.Show("Attendee Added ", "Adding Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            val.EventCapacity -= 1;
                            attendeeInfo.Items.Add($"{attendeeName.Text}\t{username.SelectedItem.ToString()}");
                        }
                    }
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
                // Close MySQL connection
                FormMain.mySqlConnection.Close();
            }


        }

        // Event handler for deleting an attendee from an event
        private void delete_Click(object sender, EventArgs e)
        {
            // Variables to store attendee information
            int count = 0;
            bool deleted = false;
            string[] attendee = attendeeInfo.SelectedItem.ToString().Split('\t');
            string username = attendee[1];
            string attendeeName = attendee[0];

            // Open MySQL connection
            FormMain.mySqlConnection.Open();

            // Loop through each attendee
            foreach (Attendees attendees in attendeeList)
            {
                // If attendee is found, delete from database and remove from attendeeList
                if (attendees.AttendeeName.ToString() == attendeeName && attendees.EventName.ToString() == eventName.SelectedItem.ToString())
                {
                    string deleteSQL = $"DELETE FROM attendeeregistration WHERE username = \"{username}\" AND event_name = \"{eventName.SelectedItem.ToString()}\"";
                    MySqlCommand mySqlCommand = new MySqlCommand(deleteSQL, FormMain.mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    deleted = true;
                    attendeeList.RemoveAt(count);
                    attendeeInfo.Items.Remove($"{attendeeName}\t{username}");
                    deleted = true;
                    break;
                }
                count++;
            }

            // If attendee is deleted successfully, update event capacity
            if (deleted)
            {
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (eventName.SelectedItem.ToString() == val.EventName.ToString())
                    {
                        string updateCapacity = $"UPDATE event SET event_capacity = {val.EventCapacity + 1} WHERE event_name = \"{eventName.SelectedItem.ToString()}\"";
                        MySqlCommand mySqlUpdateCommand = new MySqlCommand(updateCapacity, FormMain.mySqlConnection);
                        mySqlUpdateCommand.ExecuteNonQuery();
                        val.EventCapacity += 1;
                        MessageBox.Show("Attendee Deleted", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Attendee not present", "Invalid attendee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Close MySQL connection
            FormMain.mySqlConnection.Close();
        }

        // Event handler for mouse hover effect on add button
        private void add_MouseHover(object sender, EventArgs e)
        {
            add.BackColor = Color.MediumPurple;
            add.ForeColor = Color.White;
        }

        // Event handler for mouse leave effect on add button
        private void add_MouseLeave(object sender, EventArgs e)
        {
            add.BackColor = Color.Gainsboro; ;
            add.ForeColor = Color.Black;
        }

        // Event handler for mouse hover effect on delete button
        private void delete_MouseHover(object sender, EventArgs e)
        {
            delete.BackColor = Color.MediumPurple;
            delete.ForeColor = Color.White;
        }

        // Event handler for mouse leave effect on delete button
        private void delete_MouseLeave(object sender, EventArgs e)
        {
            delete.BackColor = Color.Gainsboro; ;
            delete.ForeColor = Color.Black;
        }

        // Event handler for mouse hover effect on close button


        // Event handler for close button click event
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form
        }

        private void viewProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        public void GetUserNameRole(string name, string role)
        {
            UserHome = name;
            RoleHome = role;

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RoleHome == "admin")
            {
                FormAdminHome formAdminHome = new FormAdminHome();
                formAdminHome.Show();
                this.Close();
            }
            else if (RoleHome == "EM")
            {
                EMAfterLogin eMAfterLogin = new EMAfterLogin();
                eMAfterLogin.Show();
                this.Close();
            }

        }

        private void FormManipulateAttendee_Load(object sender, EventArgs e)
        {

        }
    }
}

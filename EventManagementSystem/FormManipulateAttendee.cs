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
            attendeeInfo.Items.Clear();
            username.Items.Clear();
            FormMain.mySqlConnection.Open();
            string selectLoadSQL = "SELECT * FROM user";
            MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            
                attendeeInfo.Items.Add("Attendee Name\tUsername\n");

            if (attendeeList.Count > 0)
            {
                foreach (Attendees attendees in attendeeList)
                {
                    while (dataReader.Read())
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
                    if (eventName.SelectedItem.ToString() == attendees.EventName.ToString())
                        attendeeInfo.Items.Add($"{attendees.AttendeeName}\t\t{attendees.Username}");
                }
            }else if (attendeeList.Count == 0)
            {
                while (dataReader.Read())
                    username.Items.Add(dataReader["username"]);
            }




            FormMain.mySqlConnection.Close();
        }

        private void add_Click(object sender, EventArgs e)
        {
            FormMain.mySqlConnection.Open();
            string selectLoadSQL = $"INSERT INTO attendeeregistration (event_name, username, attendee_name) VALUES (\"{eventName.SelectedItem.ToString()}\", \"{username.SelectedItem.ToString()}\", \"{attendeeName.Text}\")";
            MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
            Attendees newAttendee = new Attendees(eventName.SelectedItem.ToString(), username.SelectedItem.ToString(), attendeeName.Text);
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
                        string updateCapacity = $"UPDATE event SET event_capacity = {val.EventCapacity - 1} WHERE event_name = \"{FormAttendeeHome.eventName}\"";
                        MySqlCommand mySqlUpdateCommand = new MySqlCommand(updateCapacity, FormMain.mySqlConnection);
                        mySqlUpdateCommand.ExecuteNonQuery();
                        
                       MessageBox.Show("Attendee Added ", "Adding Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        val.EventCapacity -= 1;
                        attendeeInfo.Items.Add($"{attendeeName.Text}\t\t{username.SelectedItem.ToString()}");
                    }

                }
            }
            FormMain.mySqlConnection.Close();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int count = 0;
            bool deleted = false;
            string[] attendee = attendeeInfo.SelectedItem.ToString().Split('\t');
            string username = attendee[2];
            string attendeeName = attendee[0];
            FormMain.mySqlConnection.Open();
            foreach (Attendees attendees in attendeeList)
            {

                if (attendees.AttendeeName.ToString() == attendeeName && attendees.EventName.ToString() == eventName.Text)
                {
                   
                    
                    string deleteSQL = $"DELETE FROM attendeeregistration WHERE username = \"{username}\" AND event_name = \"{eventName.SelectedItem.ToString()}\"";
                    MySqlCommand mySqlCommand = new MySqlCommand(deleteSQL, FormMain.mySqlConnection);
                    mySqlCommand.ExecuteNonQuery();
                    deleted = true;
                    attendeeList.RemoveAt(count);
                    attendeeInfo.Items.Remove($"{attendeeName}\t\t{username}");
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
                        string updateCapacity = $"UPDATE event SET event_capacity = {val.EventCapacity + 1} WHERE event_name = \"{FormAttendeeHome.eventName}\"";
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

            FormMain.mySqlConnection.Close();
            
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

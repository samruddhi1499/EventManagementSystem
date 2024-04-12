using System;
using System.Collections;
using System.Windows.Forms;
using MySqlConnector;

namespace EventManagementSystem
{
    public partial class FormEventEMEdit : Form
    {
        // Static variable to hold the logged-in user's name
        public static string userName;

        // Variable to store the capacity of the event before editing
        private int capacityCheck;

        // Constructor
        public FormEventEMEdit()
        {
            InitializeComponent();
        }

        // Event handler for the cancel button click
        private void btnCancelEMEdit_Click(object sender, EventArgs e)
        {
            // Closes the form
            this.Close();
        }

        // Event handler for the form load event
        private void FormEventEMEdit_Load(object sender, EventArgs e)
        {
            // Populates the event list with events associated with the logged-in user
            ArrayList arrayList = FormEventManipulation.eventObjectList;

            foreach (EventsClass array in arrayList)
            {
                EventsClass eventClass = (EventsClass)array;
                if (eventClass.EventEM.ToLower() == userName.ToLower())
                {
                    eventListEMEdit.Items.Add(eventClass.EventName.ToString());
                    if (eventListEMEdit.Items.Count == 1)
                        eventListEMEdit.Text = eventClass.EventName.ToString();
                }
            }

            // If no events are assigned to the user, displays a message box and closes the form
            if (eventListEMEdit.Items.Count == 0)
            {
                MessageBox.Show("No Event Assigned", "No Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Event handler for the OK button click
        private void btnOKEMEdit_Click(object sender, EventArgs e)
        {
            try
            {
                // Opens the database connection
                FormMain.mySqlConnection.Open();

                // Converts the capacity input to an integer
                int capacity = Convert.ToInt32(txtCapaEMEdit.Text);

                // Checks if the new capacity is greater than the previous one
                if (capacityCheck > capacity)
                {
                    MessageBox.Show("Capacity should be greater than older capacity", "Check Value ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // If capacity is valid, updates the event information in the database
                    FormEventManipulation formEventManipulation = new FormEventManipulation();

                    string eventName = eventListEMEdit.SelectedItem.ToString();
                    string sqlUpdateEMEvent = $"UPDATE event SET event_date = '{dateTimePickerEMEdit.Text}', event_time = '{timePickerEMEdit.Text}', event_loaction = '{txtLocEMEdit.Text}', event_capacity = {capacity}, event_description = '{txtDesEMEdit.Text}' WHERE event_name = '{eventName}'";
                    MySqlCommand cmd = new MySqlCommand(sqlUpdateEMEvent, FormMain.mySqlConnection);
                    cmd.ExecuteNonQuery();
                    formEventManipulation.receiveDataEdit(eventName, dateTimePickerEMEdit.Text, timePickerEMEdit.Text, capacity, txtLocEMEdit.Text, txtDesEMEdit.Text
                        , userName);
                    MessageBox.Show("Event Edit Sucessfull", "Event Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (MySqlException msqlex)
            {
                MessageBox.Show("Database Error", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Check Capacity", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Closes the database connection
                FormMain.mySqlConnection.Close();
            }
        }

        // Event handler for the event list selection change
        private void eventListEMEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Updates form fields with details of the selected event
            string selectedValue = eventListEMEdit.SelectedItem.ToString();

            ArrayList arrayList = FormEventManipulation.eventObjectList;
            EventsClass eventClass1 = (EventsClass)arrayList[0];

            foreach (EventsClass array in arrayList)
            {
                if (selectedValue == array.EventName.ToString())
                {
                    dateTimePickerEMEdit.Text = array.EventDate.ToString();
                    timePickerEMEdit.Text = array.EventTime.ToString();
                    txtCapaEMEdit.Text = array.EventCapacity.ToString();
                    capacityCheck = array.EventCapacity;
                    txtLocEMEdit.Text = array.EventLocation.ToString();
                    txtDesEMEdit.Text = array.EventDescription.ToString();
                    break;
                }
            }
        }

        // Method to set the logged-in user's name
        public void getUserName(string userName)
        {
            FormEventEMEdit.userName = userName;
        }

        // Event handlers for hover effects on buttons
        private void btnCancelEMEdit_MouseHover(object sender, EventArgs e)
        {
            btnCancelEMEdit.BackColor = Color.MediumPurple;
            btnCancelEMEdit.ForeColor = Color.White;
        }

        private void btnCancelEMEdit_MouseLeave(object sender, EventArgs e)
        {
            btnCancelEMEdit.BackColor = Color.Gainsboro;
            btnCancelEMEdit.ForeColor = Color.Black;
        }

        private void btnOKEMEdit_MouseHover(object sender, EventArgs e)
        {
            btnOKEMEdit.BackColor = Color.MediumPurple;
            btnOKEMEdit.ForeColor = Color.White;
        }

        private void btnOKEMEdit_MouseLeave(object sender, EventArgs e)
        {
            btnOKEMEdit.BackColor = Color.Gainsboro;
            btnOKEMEdit.ForeColor = Color.Black;
        }
    }
}

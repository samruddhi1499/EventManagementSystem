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
using System.Text.RegularExpressions;
using MySqlConnector;
using System.Data;
using Mysqlx.Crud;

namespace EventManagementSystem
{
    public partial class FormEventEdit : Form
    {
        // Variable to store the initial capacity for comparison
        private int capacityCheck;

        public FormEventEdit()
        {
            InitializeComponent();
        }

        // Cancel button click event handler
        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and close the form without saving
            this.Close();
        }

        // Form load event handler
        private void FormEventEdit_Load(object sender, EventArgs e)
        {
            // Load event managers into the dropdown list
            FormEventManipulation formEventManipulation = new FormEventManipulation();
            formEventManipulation.LoadAllEM();
            foreach (string em in FormEventManipulation.eventManager)
            {
                eventManagerListEdit.Items.Add(em);
            }

            // Load events into the event list
            ArrayList arrayList = FormEventManipulation.eventObjectList;
            foreach (EventsClass array in arrayList)
            {
                EventsClass eventClass = (EventsClass)array;
                eventListEdit.Items.Add(eventClass.EventName.ToString());
            }
            // Select the first event by default
            EventsClass eventClass1 = (EventsClass)arrayList[0];
            eventListEdit.Text = eventClass1.EventName.ToString();
        }

        // Form activated event handler
        private void FormEventEdit_Activated(object sender, EventArgs e)
        {
            // No action required
        }

        // Event list selection changed event handler
        private void eventListEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update form fields based on the selected event
            string selectedValue = eventListEdit.SelectedItem.ToString();
            ArrayList arrayList = FormEventManipulation.eventObjectList;
            foreach (EventsClass array in arrayList)
            {
                if (selectedValue == array.EventName.ToString())
                {
                    dateTimePickerEdit.Text = array.EventDate.ToString();
                    timePickerEventEdit.Text = array.EventTime.ToString();
                    txtCapaEdit.Text = array.EventCapacity.ToString();
                    capacityCheck = array.EventCapacity;
                    txtLocEdit.Text = array.EventLocation.ToString();
                    txtDesEdit.Text = array.EventDescription.ToString();
                    eventManagerListEdit.Text = array.EventEM.ToString();
                    break;
                }
            }
        }

        // OK button click event handler
        private void btnEditOK_Click(object sender, EventArgs e)
        {
            // Update event details in the database
            FormEventManipulation formEventManipulation = new FormEventManipulation();
            string em = eventManagerListEdit.SelectedItem.ToString();
            string eventName = eventListEdit.SelectedItem.ToString();

            try
            {
                FormMain.mySqlConnection.Open();

                int capacity = Convert.ToInt32(txtCapaEdit.Text);
                if (capacityCheck > capacity)
                {
                    MessageBox.Show("Capacity should be greater than older capacity", "Check Value ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string sqlUpdateEvent = $"UPDATE event SET event_date = '{dateTimePickerEdit.Text}', event_time = '{timePickerEventEdit.Text}', event_loaction = '{txtLocEdit.Text}', event_capacity = {capacity}, event_description = '{txtDesEdit.Text}',event_manager = '{em}' WHERE event_name = '{eventName}'";
                    MySqlCommand cmd = new MySqlCommand(sqlUpdateEvent, FormMain.mySqlConnection);
                    cmd.ExecuteNonQuery();
                    formEventManipulation.receiveDataEdit(eventName, dateTimePickerEdit.Text, timePickerEventEdit.Text, capacity, txtLocEdit.Text, txtDesEdit.Text
                    , em);
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
                FormMain.mySqlConnection.Close();
            }
        }

        // Cancel button mouse hover event handler
        private void btnEditCancel_MouseHover(object sender, EventArgs e)
        {
            btnEditCancel.BackColor = Color.MediumPurple;
            btnEditCancel.ForeColor = Color.White;
        }

        // Cancel button mouse leave event handler
        private void btnEditCancel_MouseLeave(object sender, EventArgs e)
        {
            btnEditCancel.BackColor = Color.Gainsboro;
            btnEditCancel.ForeColor = Color.Black;

        }

        // OK button mouse hover event handler
        private void btnEditOK_MouseHover(object sender, EventArgs e)
        {
            btnEditOK.BackColor = Color.MediumPurple;
            btnEditOK.ForeColor = Color.White;
        }

        // OK button mouse leave event handler
        private void btnEditOK_MouseLeave(object sender, EventArgs e)
        {
            btnEditOK.BackColor = Color.Gainsboro;
            btnEditOK.ForeColor = Color.Black;
        }
    }
}

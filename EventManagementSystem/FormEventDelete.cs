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
    public partial class FormEventDelete : Form
    {
        public FormEventDelete()
        {
            InitializeComponent();
        }

        // Cancel button click event handler
        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and close the form without saving
            this.Close();
        }

        // OK button click event handler
        private void btnDeleteOK_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain.mySqlConnection.Open();
                FormEventManipulation formEventManipulation = new FormEventManipulation();
                string eventName = eventListDelete.SelectedItem.ToString();

                // Delete event and associated registrations from the database
                string sqlDeleteEvent = $"DELETE FROM event WHERE event_name = '{eventName}'";
                string regDelete = $"DELETE FROM attendeeregistration WHERE event_name = '{eventName}'";

                // Execute SQL commands
                MySqlCommand cmd1 = new MySqlCommand(regDelete, FormMain.mySqlConnection);
                cmd1.ExecuteNonQuery();

                MySqlCommand cmd = new MySqlCommand(sqlDeleteEvent, FormMain.mySqlConnection);
                cmd.ExecuteNonQuery();

                // Notify the main form about the deletion
                formEventManipulation.receiveDataDelete(eventName);

                MessageBox.Show("Event Deletion Successful", "Event Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (MySqlException msqlex)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occurred", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
            }
        }

        // Form load event handler
        private void FormEventDelete_Load(object sender, EventArgs e)
        {
            // Populate the event list with available events
            ArrayList arrayList = FormEventManipulation.eventObjectList;
            foreach (EventsClass array in arrayList)
            {
                EventsClass eventClass = (EventsClass)array;
                eventListDelete.Items.Add(eventClass.EventName);
            }

            // Select the first event by default
            if (arrayList.Count > 0)
            {
                EventsClass eventClass1 = (EventsClass)arrayList[0];
                eventListDelete.Text = eventClass1.EventName.ToString();
            }
        }

        // Cancel button hover event handlers
        private void btnDeleteCancel_MouseHover(object sender, EventArgs e)
        {
            btnDeleteCancel.BackColor = Color.MediumPurple;
            btnDeleteCancel.ForeColor = Color.White;
        }

        private void btnDeleteCancel_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteCancel.BackColor = Color.Gainsboro;
            btnDeleteCancel.ForeColor = Color.Black;
        }

        // OK button hover event handlers
        private void btnDeleteOK_MouseHover(object sender, EventArgs e)
        {
            btnDeleteOK.BackColor = Color.MediumPurple;
            btnDeleteOK.ForeColor = Color.White;
        }

        private void btnDeleteOK_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteOK.BackColor = Color.Gainsboro;
            btnDeleteOK.ForeColor = Color.Black;
        }
    }
}

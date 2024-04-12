using MySqlConnector; // Import MySQL Connector for database operations
using System.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class FormEventAdd : Form
    {
        // Constructor
        public FormEventAdd()
        {
            InitializeComponent();
        }

        // Ok button click event handler
        private void btnAddEventOk_Click(object sender, EventArgs e)
        {
            // Close form add event and go back to event manipulation with saved changes
            try
            {
                FormMain.mySqlConnection.Open();
                int capacity = Convert.ToInt32(txtCapaAddEvent.Text);
                FormEventManipulation formEventManipulation = new FormEventManipulation();
                string em = emListAddEvent.SelectedItem.ToString();

                // Insert event data into the database
                string sqlInsertEvent = $"INSERT INTO event VALUES ('{txtAddEventName.Text}','{dateTimePickerEventAdd.Text}','{timePickerEventAdd.Text}','{txtLocAddEvent.Text}',{capacity},'{txtDesAddEvent.Text}','{em}')";
                MySqlCommand cmd = new MySqlCommand(sqlInsertEvent, FormMain.mySqlConnection);
                cmd.ExecuteNonQuery();
                // Pass event data to the FormEventManipulation form
                formEventManipulation.receiveData(txtAddEventName.Text, dateTimePickerEventAdd.Text, timePickerEventAdd.Text, capacity, txtLocAddEvent.Text, txtDesAddEvent.Text, em);
                MessageBox.Show("Event Addition Successful", "Event Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Close the form
                this.Close();
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

        // Cancel button click event handler
        private void btnAddEventCancel_Click(object sender, EventArgs e)
        {
            // Clear all text boxes and close form add event without saving
            txtAddEventName.ResetText();
            this.Close();
        }

        // Cancel button hover event handlers
        private void btnAddEventCancel_MouseHover(object sender, EventArgs e)
        {
            btnAddEventCancel.BackColor = Color.MediumPurple;
            btnAddEventCancel.ForeColor = Color.White;
        }

        private void btnAddEventCancel_MouseLeave(object sender, EventArgs e)
        {
            btnAddEventCancel.BackColor = Color.Gainsboro;
            btnAddEventCancel.ForeColor = Color.Black;
        }

        // Ok button hover event handlers
        private void btnAddEventOk_MouseLeave(object sender, EventArgs e)
        {
            btnAddEventOk.BackColor = Color.Gainsboro;
            btnAddEventOk.ForeColor = Color.Black;
        }

        private void btnAddEventOk_MouseHover(object sender, EventArgs e)
        {
            btnAddEventOk.BackColor = Color.MediumPurple;
            btnAddEventOk.ForeColor = Color.White;
        }

        // Form load event handler
        private void FormEventAdd_Load(object sender, EventArgs e)
        {
            // Load event managers into the combo box
            FormEventManipulation formEventManipulation = new FormEventManipulation();
            formEventManipulation.LoadAllEM();
            foreach (string em in FormEventManipulation.eventManager)
            {
                emListAddEvent.Items.Add(em);
            }
        }
    }
}

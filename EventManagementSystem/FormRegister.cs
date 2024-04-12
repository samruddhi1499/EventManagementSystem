using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Import for regular expressions
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    // Form for attendee registration
    public partial class FormRegister : Form
    {
        // ArrayList to store attendee objects
        public static ArrayList attendeeObjectList = new ArrayList();
        BindingSource bs = new BindingSource();
        FormAttendeeHome attendeeHome = new FormAttendeeHome();

        // Event handler for form load event
        private void FormRegister_Load(object sender, EventArgs e)
        {
            bs.DataSource = FormAttendeeHome.eventName;
        }

        // Constructor
        public FormRegister()
        {
            InitializeComponent();

            // Set event name in the form
            eventName.Text = $"Event: {FormAttendeeHome.eventName}";
        }

        // Event handler for button click event to close the form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handler for register button click event
        private void register_Click(object sender, EventArgs e)
        {
            // Call method to validate input fields
            validateFields(nameVal.Text, phoneval.Text, emailval.Text, student.Text);
        }

        // Method to validate input fields
        public void validateFields(string name, string phone, string email, string studentno)
        {
            Regex regexName = new Regex("^[a-zA-Z]+$"); // Regular expression to match only letters
            int phoneNumber;

            // Check if any field is empty
            if (nameVal.Text == "" || phoneval.Text == "" || emailval.Text == "" || student.Text == "")
            {
                MessageBox.Show(" You need to fill all the fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if name contains only letters
            else if (!regexName.IsMatch(nameVal.Text))
            {
                MessageBox.Show("Name should have only letters", "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if phone number contains only numbers
            else if (!int.TryParse(phoneval.Text, out phoneNumber))
            {
                MessageBox.Show("Phone number should have only numbers", "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if email format is valid
            else if (!emailval.Text.Contains("@"))
            {
                MessageBox.Show("Invalid EmailId", "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    // Add attendee and register for the event
                    string selectQuery = $"Select event_name from event where event_manager = '{FormAttendeeHome.Username}' and event_name = '{FormAttendeeHome.eventName}'";
                    // Open MySQL connection
                    FormMain.mySqlConnection.Open();
                    MySqlCommand mySqlCommand = new MySqlCommand(selectQuery, FormMain.mySqlConnection);
                    MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("EM cannot register", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataReader.Close();
                        FormMain.mySqlConnection.Close();
                    }
                    else
                    {
                        dataReader.Close();
                        FormMain.mySqlConnection.Close();
                        attendeeHome.addAttendee(FormAttendeeHome.eventName, FormAttendeeHome.Username, nameVal.Text, phoneval.Text, emailval.Text, student.Text);
                        attendeeHome.getRegisteredEvent(FormAttendeeHome.eventName);
                        MessageBox.Show("Event Registration Sucessfull", "Registration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
                catch (MySqlException e)
                {
                    MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Event handler for mouse leave event on register button
        private void register_MouseLeave(object sender, EventArgs e)
        {
            register.BackColor = Color.Gainsboro; ;
            register.ForeColor = Color.Black;
        }

        // Event handler for mouse hover event on register button
        private void register_MouseHover(object sender, EventArgs e)
        {
            register.BackColor = Color.MediumPurple;
            register.ForeColor = Color.White;
        }

        // Event handler for mouse hover event on close button
        private void Close_MouseHover(object sender, EventArgs e)
        {
            register.BackColor = Color.MediumPurple;
            register.ForeColor = Color.White;
        }

        // Event handler for mouse leave event on close button
        private void Close_MouseLeave(object sender, EventArgs e)
        {
            register.BackColor = Color.Gainsboro; ;
            register.ForeColor = Color.Black;
        }
    }
}

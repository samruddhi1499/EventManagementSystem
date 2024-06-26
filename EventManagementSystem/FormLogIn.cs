﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    // Form for user login
    public partial class FormLogIn : Form
    {
        // Properties to store username and password
        public string UserName { get; set; }
        public string PasswordLogin { get; set; }

        // Constructor
        public FormLogIn()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        // Event handler for login button click
        private void LogIn_Click(object sender, EventArgs e)
        {
            // Get username and password from input fields
            UserName = txtUser.Text;
            PasswordLogin = txtPass.Text;

            // Initialize forms for different user roles
            FormManipulateAttendee formManipulateAttendee = new FormManipulateAttendee();
            FormEditProfile formEditProfile = new FormEditProfile();
            FormAdminHome formAdminHome = new FormAdminHome();
            EMAfterLogin eMAfterLogin = new EMAfterLogin();
            FormAttendeeHome formAttendeeHome = new FormAttendeeHome();
            FormEventEMEdit formEventEMEdit = new FormEventEMEdit();

            try
            {
                // Open database connection
                FormMain.mySqlConnection.Open();

                // SQL query to check login credentials
                string queryLoginCheck = "SELECT * FROM User WHERE username = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(queryLoginCheck, FormMain.mySqlConnection);
                command.Parameters.AddWithValue("@username", UserName);
                command.Parameters.AddWithValue("@password", PasswordLogin);
                MySqlDataReader reader = command.ExecuteReader();
                string role = "";
                while (reader.Read())
                {
                    // If login successful
                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    role = reader["role"] + "";

                    // Navigate to appropriate form based on user role
                    if (role == "admin")
                    {
                        formManipulateAttendee.GetUserNameRole(UserName, role);
                        formEditProfile.getCredsForView(UserName, PasswordLogin);
                        formAdminHome.Show();
                        this.Hide();
                        break;
                    }
                    else if (role == "EM")
                    {
                        formEventEMEdit.getUserName(UserName);
                        formEditProfile.getCredsForView(UserName, PasswordLogin);
                        formAttendeeHome.GetUsernameRole(UserName, role);
                        formManipulateAttendee.GetUserNameRole(UserName, role);
                        this.Hide();
                        eMAfterLogin.Show();
                        break;
                    }
                    else
                    {
                        FormMain.mySqlConnection.Close();
                        formEditProfile.getCredsForView(UserName, PasswordLogin);
                        formAttendeeHome.GetUsernameRole(UserName, role);
                        this.Hide();
                        formAttendeeHome.Show();
                        break;
                    }
                }
                if (role == "")
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close database connection
                FormMain.mySqlConnection.Close();
            }

        }

        // Event handler for sign up button click
        private void SignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            this.Hide();
            formSignUp.Show();

        }

        // Event handlers for hover effects on buttons
        private void LogIn_MouseHover(object sender, EventArgs e)
        {
            LogIn.BackColor = Color.MediumPurple;
            LogIn.ForeColor = Color.White;
        }

        private void LogIn_MouseLeave(object sender, EventArgs e)
        {
            LogIn.BackColor = Color.Gainsboro;
            LogIn.ForeColor = Color.Black;
        }

        private void SignUp_MouseHover(object sender, EventArgs e)
        {
            SignUp.BackColor = Color.MediumPurple;
            SignUp.ForeColor = Color.White;
        }

        private void SignUp_MouseLeave(object sender, EventArgs e)
        {
            SignUp.BackColor = Color.Gainsboro;
            SignUp.ForeColor = Color.Black;
        }
    }
}

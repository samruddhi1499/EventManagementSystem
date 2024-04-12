using MySqlConnector; // MySQL connector library
using System; // System namespace
using System.Collections; // Collections namespace
using System.Collections.Generic; // Generic collections namespace
using System.ComponentModel; // Component model namespace
using System.Configuration; // Configuration namespace
using System.Data; // Data namespace
using System.Drawing; // Drawing namespace
using System.Linq; // LINQ namespace
using System.Text; // Text namespace
using System.Threading.Tasks; // Task-related namespace
using System.Windows.Forms; // Windows Forms namespace

namespace EventManagementSystem
{
    public partial class FormSignUp : Form
    {

        public FormSignUp()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true; // Hide password characters
            txtConfrmPass.UseSystemPasswordChar = true; // Hide password characters
        }

        // Event handler for login button click
        private void Login_Click(object sender, EventArgs e)
        {
            FormLogIn formLogin = new FormLogIn();
            this.Close(); // Close sign up form
            formLogin.Show(); // Show login form
        }

        // Event handler for signup button click
        private void Signup_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text; // Get username from textbox
            string pass = txtPassword.Text; // Get password from textbox
            string confirm = txtConfrmPass.Text; // Get password confirmation from textbox

            // Define password strength criteria
            int minLength = 8; // Minimum length of password
            bool hasUpperCase = false; // Flag for uppercase letter presence
            bool hasLowerCase = false; // Flag for lowercase letter presence
            bool hasDigit = false; // Flag for digit presence
            bool hasSpecialChar = false; // Flag for special character presence
            string specialCharacters = "!@#$%^&*()-_=+"; // Special characters allowed in password

            // Check if password meets the minimum length requirement
            if (pass.Length < minLength)
            {
                MessageBox.Show($"Password must be at least {minLength} characters long", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                return;
            }

            // Check for other password strength criteria
            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                {
                    hasUpperCase = true;
                }
                else if (char.IsLower(c))
                {
                    hasLowerCase = true;
                }
                else if (char.IsDigit(c))
                {
                    hasDigit = true;
                }
                else if (specialCharacters.Contains(c))
                {
                    hasSpecialChar = true;
                }
            }

            // Check if password meets all criteria
            if (!hasUpperCase || !hasLowerCase || !hasDigit || !hasSpecialChar)
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one digit, and one special character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                return;
            }

            // Check if passwords match
            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                return;
            }

            // Insert user into database
            try
            {
                FormMain.mySqlConnection.Open(); // Open database connection
                string query = "INSERT INTO User (username, password) VALUES (@username, @password)"; // SQL query to insert user

                MySqlCommand command = new MySqlCommand(query, FormMain.mySqlConnection); // MySQL command object
                command.Parameters.AddWithValue("@username", username); // Add username parameter
                command.Parameters.AddWithValue("@password", pass); // Add password parameter
                command.ExecuteNonQuery(); // Execute command

                MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message
                FormLogIn formLogin = new FormLogIn(); // Create login form object
                this.Close(); // Close sign up form
                formLogin.Show(); // Show login form
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062) // MySQL error number for duplicate entry
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                }
                else
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                }
            }
            finally
            {
                FormMain.mySqlConnection.Close(); // Close database connection
            }

            // Reset text fields
            txtuser.ResetText();
            txtPassword.ResetText();
            txtConfrmPass.ResetText();
        }

        // Event handler for login button mouse hover
        private void Login_MouseHover(object sender, EventArgs e)
        {
            Login.BackColor = Color.MediumPurple; // Change login button background color
            Login.ForeColor = Color.White; // Change login button text color
        }

        // Event handler for login button mouse leave
        private void Login_MouseLeave(object sender, EventArgs e)
        {
            Login.BackColor = Color.Gainsboro; // Change login button background color
            Login.ForeColor = Color.Black; // Change login button text color
        }

        // Event handler for signup button mouse hover
        private void Signup_MouseHover(object sender, EventArgs e)
        {
            Signup.BackColor = Color.MediumPurple; // Change signup button background color
            Signup.ForeColor = Color.White; // Change signup button text color
        }

        // Event handler for signup button mouse leave
        private void Signup_MouseLeave(object sender, EventArgs e)
        {
            Signup.BackColor = Color.Gainsboro; // Change signup button background color
            Signup.ForeColor = Color.Black; // Change signup button text color
        }

        // Event handler for username textbox click
        private void txtusername_Click(object sender, EventArgs e)
        {

        }
    }
}

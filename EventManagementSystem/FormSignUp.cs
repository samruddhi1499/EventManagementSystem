using MySqlConnector;
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

namespace EventManagementSystem
{
    public partial class FormSignUp : Form
    {

        public FormSignUp()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            txtConfrmPass.UseSystemPasswordChar = true;
        }



        private void Login_Click(object sender, EventArgs e)
        {
            FormLogIn formLogin = new FormLogIn();
            this.Close();
            formLogin.Show();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string pass = txtPassword.Text;
            string confirm = txtConfrmPass.Text;

            if (pass != confirm)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert user into database
            try
            {
                FormMain.mySqlConnection.Open();
                string query = "INSERT INTO User (username, password) VALUES (@username, @password)";

                MySqlCommand command = new MySqlCommand(query, FormMain.mySqlConnection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", pass);
                command.ExecuteNonQuery();

                MessageBox.Show("Registration successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormLogIn formLogin = new FormLogIn();
                this.Close();
                formLogin.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                FormMain.mySqlConnection.Close();
            }

            txtuser.ResetText();
            txtPassword.ResetText();
            txtConfrmPass.ResetText();

        }

        private void Login_MouseHover(object sender, EventArgs e)
        {
            Login.BackColor = Color.MediumPurple;
            Login.ForeColor = Color.White;

        }

        private void Login_MouseLeave(object sender, EventArgs e)
        {
            Login.BackColor = Color.Gainsboro; ;
            Login.ForeColor = Color.Black;

        }

        private void Signup_MouseHover(object sender, EventArgs e)
        {
            Signup.BackColor = Color.MediumPurple;
            Signup.ForeColor = Color.White;
        }

        private void Signup_MouseLeave(object sender, EventArgs e)
        {
            Signup.BackColor = Color.Gainsboro; ;
            Signup.ForeColor = Color.Black;
        }

        private void txtusername_Click(object sender, EventArgs e)
        {

        }
    }
}

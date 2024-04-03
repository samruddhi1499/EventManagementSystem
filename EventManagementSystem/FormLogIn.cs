using MySqlConnector;
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

    public partial class FormLogIn : Form
    {
        public string UserName { get; set; }
        public string PasswordLogin { get; set; }
        public FormLogIn()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            UserName = txtUser.Text;
            PasswordLogin = txtPass.Text;

            try
            {
                FormMain.mySqlConnection.Open();

                string queryLoginCheck = "SELECT * FROM User WHERE username = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(queryLoginCheck, FormMain.mySqlConnection);
                command.Parameters.AddWithValue("@username", UserName);
                command.Parameters.AddWithValue("@password", PasswordLogin);
                MySqlDataReader reader = command.ExecuteReader();
                string role = "";
                while (reader.Read()) {

                    MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                   
                    role = reader["role"] + "";
                    

                    if (role == "admin")
                    {
                        FormAdminHome formAdminHome = new FormAdminHome();
                        FormEditProfile formEditProfile = new FormEditProfile();
                        formEditProfile.getCredsForView(UserName, PasswordLogin);
                        formAdminHome.Show();
                        this.Hide();
                    }
                    else if (role == "EM")
                    {

                        EMAfterLogin eMAfterLogin = new EMAfterLogin();
                        FormEventEMEdit formEventEMEdit = new FormEventEMEdit();
                        formEventEMEdit.getUserName(UserName);
                        FormEditProfile formEditProfile = new FormEditProfile();
                        formEditProfile.getCredsForView(UserName, PasswordLogin);
                        this.Hide();
                        eMAfterLogin.Show();
                    }
                    else
                    {
                        FormAttendeeHome formAttendeeHome = new FormAttendeeHome();
                        FormEditProfile formEditProfile = new FormEditProfile();
                        formEditProfile.getCredsForView(UserName, PasswordLogin);
                        this.Hide();
                        formAttendeeHome.Show();
                    }
                }
                if(role == "")
                    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
            }

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            this.Hide();
            formSignUp.Show();

        }

        private void LogIn_MouseHover(object sender, EventArgs e)
        {
            LogIn.BackColor = Color.MediumPurple;
            LogIn.ForeColor = Color.White;
        }

        private void LogIn_MouseLeave(object sender, EventArgs e)
        {
            LogIn.BackColor = Color.Gainsboro; ;
            LogIn.ForeColor = Color.Black;
        }

        private void SignUp_MouseHover(object sender, EventArgs e)
        {
            SignUp.BackColor = Color.MediumPurple;
            SignUp.ForeColor = Color.White;
        }

        private void SignUp_MouseLeave(object sender, EventArgs e)
        {
            SignUp.BackColor = Color.Gainsboro; ;
            SignUp.ForeColor = Color.Black;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        }

        private void LogIn_Click(object sender, EventArgs e)
        {


            UserName = txtUser.Text;
            PasswordLogin = txtPass.Text;
            

            if (UserName == "admin" && PasswordLogin == "admin123")
            {
                MessageBox.Show("LogIn Successful", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdminHome formAdminHome = new FormAdminHome();
                FormEditProfile formEditProfile = new FormEditProfile();
                formEditProfile.getCredsForView(UserName, PasswordLogin);
                this.Hide();
                formAdminHome.Show();

            }
            else if ((UserName == "Sam" && PasswordLogin == "sam123") || (UserName == "Saloni" && PasswordLogin == "saloni123") || (UserName == "Sruthi" && PasswordLogin == "sruthi123"))
            {
                MessageBox.Show("Login Successful", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EMAfterLogin eMAfterLogin = new EMAfterLogin();
                FormEventEMEdit formEventEMEdit = new FormEventEMEdit();
                formEventEMEdit.getUserName(UserName);
                FormAttendeeHome formAttendeeHome = new FormAttendeeHome();
                FormEditProfile formEditProfile = new FormEditProfile();
                formEditProfile.getCredsForView(UserName, PasswordLogin);
                formAttendeeHome.GetUsername(UserName);
                this.Hide();
                eMAfterLogin.Show();

            }
            else if ((UserName == "Attendee1" && PasswordLogin == "a123") || (UserName == "Attendee2" && PasswordLogin == "attendee_2_123"))
            {
                MessageBox.Show("Login Successful", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAttendeeHome formAttendeeHome = new FormAttendeeHome();
                FormEditProfile formEditProfile = new FormEditProfile();
                formEditProfile.getCredsForView(UserName, PasswordLogin);
                formAttendeeHome.GetUsername(UserName);
                this.Hide();
                formAttendeeHome.Show();
            }
            else
            {
                MessageBox.Show("Enter valid Username and Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtUser.ResetText();
            txtPass.ResetText();
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

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
        }

        private void LogIn_Click(object sender, EventArgs e)
        {


            UserName = txtUser.Text;
            PasswordLogin = txtPass.Text;

            if (UserName == "admin" && PasswordLogin == "admin123")
            {
                MessageBox.Show("LogIn Successful", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdminHome formAdminHome = new FormAdminHome();
                this.Hide();
                formAdminHome.Show();
                
            }
            else if ((UserName == "Sam" && PasswordLogin == "sam123") || (UserName == "Saloni" && PasswordLogin == "saloni123") || (UserName == "Sruthi" && PasswordLogin == "sruthi123" ))
            {
                MessageBox.Show("Login Successful", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EMAfterLogin eMAfterLogin = new EMAfterLogin();
                FormEventEMEdit formEventEMEdit = new FormEventEMEdit();
                formEventEMEdit.getUserName(UserName);
                this.Hide();
                eMAfterLogin.Show();
                
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
    }
}

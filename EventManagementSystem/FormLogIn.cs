using System;
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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string userName, password;

            userName = txtUser.Text;
            password = txtPass.Text;

            if (userName == "admin" && password == "admin123")
            {
                MessageBox.Show("LogIn Successful", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            formSignUp.ShowDialog();
            
        }
    }
}

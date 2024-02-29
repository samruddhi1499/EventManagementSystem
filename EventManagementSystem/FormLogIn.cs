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
                MessageBox.Show("LogIn Successful");
            }
            else
            {
                MessageBox.Show("Enter valid Username and Password ");
            }
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.ShowDialog();
            //FormEventAdd formEventAdd = new FormEventAdd();
            //formEventAdd.ShowDialog();
        }
    }
}

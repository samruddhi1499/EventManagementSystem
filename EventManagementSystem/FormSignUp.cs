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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }



        private void Login_Click(object sender, EventArgs e)
        {
            FormLogIn formLogin = new FormLogIn();
            this.Hide();
            formLogin.ShowDialog();
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            string username = txtuser.Text;
            string pass = txtPassword.Text;
            string confirm = txtConfrmPass.Text;

            if (username == "admin" && pass == "admin123" && confirm == "admin123")
            {
                MessageBox.Show("Register Successful", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormEventManipulation formEventManipulation = new FormEventManipulation();
                this.Hide();
                formEventManipulation.ShowDialog();

            }
            else if ((username == "Sam" && pass == "sam123" && confirm == "sam123") || (username == "Saloni" && pass == "saloni123" && confirm == "saloni123") || (username == "Sruthi" && pass == "sruthi123" && confirm == "sruthi123"))
            {
                MessageBox.Show("Register Successful", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EMAfterLogin eMAfterLogin = new EMAfterLogin();
                this.Hide();
                eMAfterLogin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Check Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtuser.ResetText();
            txtPassword.ResetText();
            txtConfrmPass.ResetText();

            this.Hide();
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
    }
}

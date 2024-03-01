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

            if (username == "admin" && pass =="admin123" && confirm == "admin123")
            {
                MessageBox.Show("Register Successful", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}

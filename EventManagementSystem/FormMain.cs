﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            //FormMain formMain = new FormMain();
            //this.Hide();
            //formMain.ShowDialog();

            FormLogIn formLogin = new FormLogIn();

            formLogin.Show();
            this.Hide();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();

            formSignUp.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_MouseHover(object sender, EventArgs e)
        {
            login.BackColor = Color.MediumPurple;
            login.ForeColor = Color.White;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.BackColor = Color.Gainsboro;
            login.ForeColor = Color.Black;
        }

        private void signup_MouseHover(object sender, EventArgs e)
        {
            signup.BackColor = Color.MediumPurple;
            signup.ForeColor = Color.White;
        }

        private void signup_MouseLeave(object sender, EventArgs e)
        {
            signup.BackColor = Color.Gainsboro;
            signup.ForeColor = Color.Black;
        }
    }
}

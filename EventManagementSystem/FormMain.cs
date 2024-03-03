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
            this.Hide();
            formLogin.Show();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            this.Hide();
            formSignUp.Show();
        }
    }
}

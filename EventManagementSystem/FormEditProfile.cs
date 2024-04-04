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
    public partial class FormEditProfile : Form
    {
        public static string userNameForView;
        public static string passwordForView;
        public FormEditProfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditProfile_Load(object sender, EventArgs e)
        {
            if (userNameForView == "admin")
            {
                txtViewUsername.Text = userNameForView;
                txtViewPass.Text = passwordForView;
            }
            else if (userNameForView == "Sam" || userNameForView == "Saloni" || userNameForView == "Sruthi")
            {
                txtViewUsername.Text = userNameForView;
                txtViewPass.Text = passwordForView;
            }
            else
            {
                txtViewUsername.Text = userNameForView;
                txtViewPass.Text = passwordForView;
            }
        }

        public void getCredsForView(string userName, string password)
        {
            FormEditProfile.userNameForView = userName;
            FormEditProfile.passwordForView = password;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.MediumPurple;
            button1.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gainsboro;
            button1.ForeColor = Color.Black;
        }

    }
}

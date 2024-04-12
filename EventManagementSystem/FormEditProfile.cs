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
        // Variables to store username and password for viewing
        public static string userNameForView;
        public static string passwordForView;

        // Constructor
        public FormEditProfile()
        {
            InitializeComponent();
        }

        // Close button click event handler
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Form load event handler
        private void FormEditProfile_Load(object sender, EventArgs e)
        {
            // Load username and password for viewing
            txtViewUsername.Text = userNameForView;
            txtViewPass.Text = passwordForView;
        }

        // Method to set username and password for viewing
        public void getCredsForView(string userName, string password)
        {
            FormEditProfile.userNameForView = userName;
            FormEditProfile.passwordForView = password;
        }

        // Close button hover event handlers
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

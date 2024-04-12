using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class FormAdminHome : Form
    {
        public FormAdminHome()
        {
            InitializeComponent();
        }

        // Event handler for clicking "User Management" button
        private void btnUserMan_Click(object sender, EventArgs e)
        {
            // Open the form for user role selection
            FormSelectRole role = new FormSelectRole();
            this.Close();
            role.Show();
        }

        // Event handler for clicking "Event Management" button
        private void btnEventMan_Click(object sender, EventArgs e)
        {
            // Open the form for event manipulation
            FormEventManipulation formEventManipulation = new FormEventManipulation();
            this.Close();
            formEventManipulation.Show();
        }

        // Event handler for clicking "Logout" option in the menu
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the current form and open the login form
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        // Event handler for clicking "Attendee Management" button
        private void btnAttendeeMan_Click(object sender, EventArgs e)
        {
            // Open the form for attendee manipulation
            FormManipulateAttendee formManipulateAttendee = new FormManipulateAttendee();
            this.Close();
            formManipulateAttendee.Show();
        }

        // Event handler for clicking "Edit Profile" option in the menu
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the form for profile editing
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        // Event handler for mouse hover on "Event Management" button
        private void btnEventMan_MouseHover(object sender, EventArgs e)
        {
            btnEventMan.BackColor = Color.MediumPurple;
            btnEventMan.ForeColor = Color.White;
        }

        // Event handler for mouse leaving "Event Management" button
        private void btnEventMan_MouseLeave(object sender, EventArgs e)
        {
            btnEventMan.BackColor = Color.Gainsboro;
            btnEventMan.ForeColor = Color.Black;
        }

        // Event handler for mouse hover on "Attendee Management" button
        private void btnAttendeeMan_MouseHover(object sender, EventArgs e)
        {
            btnAttendeeMan.BackColor = Color.MediumPurple;
            btnAttendeeMan.ForeColor = Color.White;
        }

        // Event handler for mouse leaving "Attendee Management" button
        private void btnAttendeeMan_MouseLeave(object sender, EventArgs e)
        {
            btnAttendeeMan.BackColor = Color.Gainsboro;
            btnAttendeeMan.ForeColor = Color.Black;
        }

        // Event handler for mouse hover on "User Management" button
        private void btnUserMan_MouseHover(object sender, EventArgs e)
        {
            btnUserMan.BackColor = Color.MediumPurple;
            btnUserMan.ForeColor = Color.White;
        }

        // Event handler for mouse leaving "User Management" button
        private void btnUserMan_MouseLeave(object sender, EventArgs e)
        {
            btnUserMan.BackColor = Color.Gainsboro;
            btnUserMan.ForeColor = Color.Black;
        }

        // Event handler for mouse hover on "Edit Profile" option in the menu
        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripMenuItem1.BackColor = Color.MediumPurple;
            toolStripMenuItem1.ForeColor = Color.White;
        }

        // Event handler for mouse leaving "Edit Profile" option in the menu
        private void toolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripMenuItem1.BackColor = Color.Gainsboro;
            toolStripMenuItem1.ForeColor = Color.Black;
        }
    }
}

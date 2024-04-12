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
    public partial class EMAfterLogin : Form
    {
        public EMAfterLogin()
        {
            InitializeComponent();
        }

        // Event handler for clicking "Edit Event" button
        private void btnEMEditEvent_Click(object sender, EventArgs e)
        {
            // Open the form for event editing
            FormEventEMEdit formEMEventEdit = new FormEventEMEdit();
            formEMEventEdit.ShowDialog();
        }

        // Event handler for clicking "Logout" option in the menu
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the current form and open the login form
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        // Event handler for clicking "Manage Attendees" button
        private void btnAttendee_Click(object sender, EventArgs e)
        {
            // Open the form for attendee manipulation
            FormManipulateAttendee formManipulateAttendee = new FormManipulateAttendee();
            formManipulateAttendee.Show();
            this.Close();
        }

        // Event handler for clicking "Edit Profile" option in the menu
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the form for profile editing
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        // Event handler for mouse hover on "Edit Event" button
        private void btnEMEditEvent_MouseHover(object sender, EventArgs e)
        {
            // Change button appearance on hover
            btnEMEditEvent.BackColor = Color.MediumPurple;
            btnEMEditEvent.ForeColor = Color.White;
        }

        // Event handler for mouse leaving "Edit Event" button
        private void btnEMEditEvent_MouseLeave(object sender, EventArgs e)
        {
            // Change button appearance when mouse leaves
            btnEMEditEvent.BackColor = Color.Gainsboro;
            btnEMEditEvent.ForeColor = Color.Black;
        }

        // Event handler for mouse hover on "Manage Attendees" button
        private void btnAttendee_MouseHover(object sender, EventArgs e)
        {
            // Change button appearance on hover
            btnAttendee.BackColor = Color.MediumPurple;
            btnAttendee.ForeColor = Color.White;
        }

        // Event handler for mouse leaving "Manage Attendees" button
        private void btnAttendee_MouseLeave(object sender, EventArgs e)
        {
            // Change button appearance when mouse leaves
            btnAttendee.BackColor = Color.Gainsboro;
            btnAttendee.ForeColor = Color.Black;
        }

        // Event handler for clicking "Register" option in the menu
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close the current form and open the attendee home form
            FormAttendeeHome formAttendeeHome = new FormAttendeeHome();
            this.Close();
            formAttendeeHome.Show();
        }
    }
}

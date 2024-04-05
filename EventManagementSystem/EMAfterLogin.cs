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

        private void btnEMEditEvent_Click(object sender, EventArgs e)
        {

            FormEventEMEdit formEMEventEdit = new FormEventEMEdit();
            formEMEventEdit.ShowDialog();

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        private void btnAttendee_Click(object sender, EventArgs e)
        {
            FormManipulateAttendee formManipulateAttendee = new FormManipulateAttendee();
            formManipulateAttendee.Show();
            this.Close();

        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        private void btnEMEditEvent_MouseHover(object sender, EventArgs e)
        {
            btnEMEditEvent.BackColor = Color.MediumPurple;
            btnEMEditEvent.ForeColor = Color.White;
        }

        private void btnEMEditEvent_MouseLeave(object sender, EventArgs e)
        {
            btnEMEditEvent.BackColor = Color.Gainsboro;
            btnEMEditEvent.ForeColor = Color.Black;
        }

        private void btnAttendee_MouseHover(object sender, EventArgs e)
        {
            btnAttendee.BackColor = Color.MediumPurple;
            btnAttendee.ForeColor = Color.White;
        }

        private void btnAttendee_MouseLeave(object sender, EventArgs e)
        {
            btnAttendee.BackColor = Color.Gainsboro;
            btnAttendee.ForeColor = Color.Black;
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAttendeeHome formAttendeeHome = new FormAttendeeHome();
            this.Close();
            formAttendeeHome.Show();

        }
    }
}

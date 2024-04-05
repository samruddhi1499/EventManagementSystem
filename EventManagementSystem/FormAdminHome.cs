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

        private void btnUserMan_Click(object sender, EventArgs e)
        {
            FormSelectRole role = new FormSelectRole();
            this.Close();
            role.Show();
        }

        private void btnEventMan_Click(object sender, EventArgs e)
        {
            FormEventManipulation formEventManipulation = new FormEventManipulation();
            this.Close();
            formEventManipulation.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        private void btnAttendeeMan_Click(object sender, EventArgs e)
        {
            FormManipulateAttendee formManipulateAttendee = new FormManipulateAttendee();
            this.Close();
            formManipulateAttendee.Show();
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        private void btnEventMan_MouseHover(object sender, EventArgs e)
        {
            btnEventMan.BackColor = Color.MediumPurple;
            btnEventMan.ForeColor = Color.White;
        }

        private void btnEventMan_MouseLeave(object sender, EventArgs e)
        {
            btnEventMan.BackColor = Color.Gainsboro;
            btnEventMan.ForeColor = Color.Black;
        }



        private void btnAttendeeMan_MouseHover(object sender, EventArgs e)
        {
            btnAttendeeMan.BackColor = Color.MediumPurple; 
            btnAttendeeMan.ForeColor = Color.White;
        }

        private void btnAttendeeMan_MouseLeave(object sender, EventArgs e)
        {
            btnAttendeeMan.BackColor = Color.Gainsboro;
            btnAttendeeMan.ForeColor= Color.Black;
        }

        private void btnUserMan_MouseHover(object sender, EventArgs e)
        {
            btnUserMan.BackColor = Color.MediumPurple;
            btnUserMan.ForeColor = Color.White;
        }

        private void btnUserMan_MouseLeave(object sender, EventArgs e)
        {
            btnUserMan.BackColor = Color.Gainsboro;
            btnUserMan.ForeColor = Color.Black;
        }

        private void toolStripMenuItem1_MouseHover(object sender, EventArgs e)
        {
            toolStripMenuItem1.BackColor = Color.MediumPurple;
            toolStripMenuItem1.ForeColor = Color.White;
        }

        private void toolStripMenuItem1_MouseLeave(object sender, EventArgs e)
        {
            toolStripMenuItem1.BackColor = Color.Gainsboro;
            toolStripMenuItem1.ForeColor = Color.Black;
        }

        
    }
}

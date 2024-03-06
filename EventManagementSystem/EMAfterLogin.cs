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
            formManipulateAttendee.ShowDialog();
        }
    }
}

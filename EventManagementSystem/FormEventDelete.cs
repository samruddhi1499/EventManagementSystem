using System;
using System.Collections;
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
    public partial class FormEventDelete : Form
    {
        public FormEventDelete()
        {
            InitializeComponent();
        }


        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            // clear all text box and close form add event without saving
            this.Close();
        }

        private void btnDeleteOK_Click(object sender, EventArgs e)
        {
            FormEventManipulation formEventManipulation = new FormEventManipulation();

            string eventName = eventListDelete.SelectedItem.ToString();
            formEventManipulation.receiveDataDelete(eventName);
            MessageBox.Show("Event Deleted", "Event Deletion Sucessfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
        private void FormEventDelete_Activated(object sender, EventArgs e)
        {


        }

        private void FormEventDelete_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = FormEventManipulation.eventObjectList;

           

            foreach (EventsClass array in arrayList)
            {
                EventsClass eventClass = (EventsClass)array;
                eventListDelete.Items.Add(eventClass.EventName);
            }
            EventsClass eventClass1 = (EventsClass)arrayList[0];

            eventListDelete.Text = eventClass1.EventName.ToString();
        }
    }
}

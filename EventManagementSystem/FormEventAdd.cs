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
    public partial class FormEventAdd : Form
    {
        public FormEventAdd()
        {
            InitializeComponent();
        }

        private void btnAddEventOk_Click(object sender, EventArgs e)
        {
            // close form add event and go back to event manipulation with saved changes
            FormEventManipulation formEventManipulation = new FormEventManipulation();
            string em = emListAddEvent.SelectedItem.ToString();
            formEventManipulation.receiveData(txtAddEventName.Text,dateTimePickerEventAdd.Text,txtTimeAddEvent.Text,txtCapaAddEvent.Text,txtLocAddEvent.Text,txtDesAddEvent.Text
                ,em );
            this.Close();
        }

        private void btnAddEventCancel_Click(object sender, EventArgs e)
        {
            // clear all text box and close form add event without saving
            txtAddEventName.ResetText();
            this.Close();
        }
    }
}

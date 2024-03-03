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
    public partial class FormEventEMEdit : Form
    {
        public static string userName;
        public FormEventEMEdit()
        {
            InitializeComponent();
        }

        private void btnCancelEMEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEventEMEdit_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = FormEventManipulation.eventObjectList;
            
            
            
            foreach (EventsClass array in arrayList)
            {
                EventsClass eventClass = (EventsClass)array;
                if (eventClass.EventEM.ToLower() == userName.ToLower())
                {
                    eventListEMEdit.Items.Add(eventClass.EventName.ToString());
                    if (eventListEMEdit.Items.Count == 1)
                        eventListEMEdit.Text = eventClass.EventName.ToString();
                }


            }


        }
      
      
        private void btnOKEMEdit_Click(object sender, EventArgs e)
        {
            

            try
            {
                int capacity = Convert.ToInt32(txtCapaEMEdit.Text);
                FormEventManipulation formEventManipulation = new FormEventManipulation();

                string eventName = eventListEMEdit.SelectedItem.ToString();
                formEventManipulation.receiveDataEdit(eventName, dateTimePickerEMEdit.Text, timePickerEMEdit.Text, txtCapaEMEdit.Text, txtLocEMEdit.Text, txtDesEMEdit.Text
                    , userName);
                MessageBox.Show("Event Edit Sucessfull", "Event Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Check Capacity", "Invalid Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void eventListEMEdit_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = eventListEMEdit.SelectedItem.ToString();

            ArrayList arrayList = FormEventManipulation.eventObjectList;
            EventsClass eventClass1 = (EventsClass)arrayList[0];
           
            foreach (EventsClass array in arrayList)
            {
                if (selectedValue == array.EventName.ToString())
                {
                    dateTimePickerEMEdit.Text = array.EventDate.ToString();
                    timePickerEMEdit.Text = array.EventTime.ToString();
                    txtCapaEMEdit.Text = array.EventCapacity.ToString();
                    txtLocEMEdit.Text = array.EventLocation.ToString();
                    txtDesEMEdit.Text = array.EventDescription.ToString();
                    break;
                }
            }
        }

        public void getUserName(string userName)
        {
            FormEventEMEdit.userName = userName;
        }
    }
}

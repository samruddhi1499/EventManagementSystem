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
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventManagementSystem
{
    public partial class FormEventEdit : Form
    {

        
        public FormEventEdit()
        {
            InitializeComponent();
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            // clear all text box and close form add event without saving
            this.Close();
        }

        private void FormEventEdit_Load(object sender, EventArgs e)
        {

            
            ArrayList arrayList = FormEventManipulation.eventObjectList;


            foreach (EventsClass array in arrayList)
            {
                EventsClass eventClass = (EventsClass)array;
                eventListEdit.Items.Add(eventClass.EventName.ToString());
            }
            EventsClass eventClass1 = (EventsClass)arrayList[0];
            eventListEdit.Text = eventClass1.EventName.ToString();



        }

        private void FormEventEdit_Activated(object sender, EventArgs e)
        {


        }

        private void eventListEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = eventListEdit.SelectedItem.ToString();
            
            ArrayList arrayList = FormEventManipulation.eventObjectList;
            foreach (EventsClass array in arrayList)
            {
                if (selectedValue == array.EventName.ToString())
                {
                    dateTimePickerEdit.Text = array.EventDate.ToString();
                    timePickerEventEdit.Text = array.EventTime.ToString();
                    txtCapaEdit.Text = array.EventCapacity.ToString();
                    txtLocEdit.Text = array.EventLocation.ToString();
                    txtDesEdit.Text = array.EventDescription.ToString();
                    eventManagerListEdit.Text = array.EventEM.ToString();
                    break;
                }
            }

        }

        private void btnEditOK_Click(object sender, EventArgs e)
        {
            FormEventManipulation formEventManipulation = new FormEventManipulation();
            string em = eventManagerListEdit.SelectedItem.ToString();
            string eventName = eventListEdit.SelectedItem.ToString();

            try
            {
                int capacity = Convert.ToInt32(txtCapaEdit.Text);
                formEventManipulation.receiveDataEdit(eventName, dateTimePickerEdit.Text, timePickerEventEdit.Text, txtCapaEdit.Text, txtLocEdit.Text, txtDesEdit.Text
                , em);
                MessageBox.Show("Event Edit Sucessfull", "Event Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check Capacity", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}

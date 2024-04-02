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
using MySqlConnector;
using System.Data;
using Mysqlx.Crud;

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
            foreach (string em in FormEventManipulation.eventManager)
            {
                eventManagerListEdit.Items.Add(em);
            }

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
                FormMain.mySqlConnection.Open();
                int capacity = Convert.ToInt32(txtCapaEdit.Text);
                string sqlUpdateEvent = $"UPDATE event SET event_date = '{dateTimePickerEdit.Text}', event_time = '{timePickerEventEdit.Text}', event_loaction = '{txtLocEdit.Text}', event_capacity = {capacity}, event_description = '{txtDesEdit.Text}',event_manager = '{em}' WHERE event_name = '{eventName}'";
                MySqlCommand cmd = new MySqlCommand(sqlUpdateEvent, FormMain.mySqlConnection);
                cmd.ExecuteNonQuery();
                formEventManipulation.receiveDataEdit(eventName, dateTimePickerEdit.Text, timePickerEventEdit.Text, txtCapaEdit.Text, txtLocEdit.Text, txtDesEdit.Text
                , em);
                MessageBox.Show("Event Edit Sucessfull", "Event Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.Close();
            }
            catch (MySqlException msqlex)
            {
                MessageBox.Show("Database Error", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check Capacity", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
            }

        }

        private void btnEditCancel_MouseHover(object sender, EventArgs e)
        {
            btnEditCancel.BackColor = Color.MediumPurple;
            btnEditCancel.ForeColor = Color.White;
        }

        private void btnEditCancel_MouseLeave(object sender, EventArgs e)
        {
            btnEditCancel.BackColor = Color.Gainsboro;
            btnEditCancel.ForeColor = Color.Black;

        }

        private void btnEditOK_MouseHover(object sender, EventArgs e)
        {
            btnEditOK.BackColor = Color.MediumPurple;
            btnEditOK.ForeColor = Color.White;
        }

        private void btnEditOK_MouseLeave(object sender, EventArgs e)
        {
            btnEditOK.BackColor = Color.Gainsboro;
            btnEditOK.ForeColor = Color.Black;
        }
    }
}

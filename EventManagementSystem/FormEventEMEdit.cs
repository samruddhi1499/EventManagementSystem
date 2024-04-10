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
using MySqlConnector;
using System.Data;
using Mysqlx.Crud;

namespace EventManagementSystem
{

    public partial class FormEventEMEdit : Form
    {
        public static string userName;
        private int capacityCheck;
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
            if(eventListEMEdit.Items.Count == 0)
            {
                MessageBox.Show("No Event Assigned", "No Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            



        }


        private void btnOKEMEdit_Click(object sender, EventArgs e)
        {


            try
            {
                FormMain.mySqlConnection.Open();
                int capacity = Convert.ToInt32(txtCapaEMEdit.Text);
                if (capacityCheck > capacity)
                {
                    MessageBox.Show("Capacity should be greater than older capacity", "Check Value ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    FormEventManipulation formEventManipulation = new FormEventManipulation();

                    string eventName = eventListEMEdit.SelectedItem.ToString();
                    string sqlUpdateEMEvent = $"UPDATE event SET event_date = '{dateTimePickerEMEdit.Text}', event_time = '{timePickerEMEdit.Text}', event_loaction = '{txtLocEMEdit.Text}', event_capacity = {capacity}, event_description = '{txtDesEMEdit.Text}' WHERE event_name = '{eventName}'";
                    MySqlCommand cmd = new MySqlCommand(sqlUpdateEMEvent, FormMain.mySqlConnection);
                    cmd.ExecuteNonQuery();
                    formEventManipulation.receiveDataEdit(eventName, dateTimePickerEMEdit.Text, timePickerEMEdit.Text, capacity, txtLocEMEdit.Text, txtDesEMEdit.Text
                        , userName);
                    MessageBox.Show("Event Edit Sucessfull", "Event Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                

            }
            catch (MySqlException msqlex)
            {
                MessageBox.Show("Database Error", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Check Capacity", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
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
                    capacityCheck = array.EventCapacity;
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

        private void btnCancelEMEdit_MouseHover(object sender, EventArgs e)
        {
            btnCancelEMEdit.BackColor = Color.MediumPurple;
            btnCancelEMEdit.ForeColor = Color.White;
        }

        private void btnCancelEMEdit_MouseLeave(object sender, EventArgs e)
        {
            btnCancelEMEdit.BackColor = Color.Gainsboro;
            btnCancelEMEdit.ForeColor = Color.Black;
        }

        private void btnOKEMEdit_MouseHover(object sender, EventArgs e)
        {
            btnOKEMEdit.BackColor = Color.MediumPurple;
            btnOKEMEdit.ForeColor = Color.White;
        }

        private void btnOKEMEdit_MouseLeave(object sender, EventArgs e)
        {
            btnOKEMEdit.BackColor = Color.Gainsboro;
            btnOKEMEdit.ForeColor = Color.Black;
        }
    }
}

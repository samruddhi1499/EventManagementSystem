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
            try {
                FormMain.mySqlConnection.Open();
                FormEventManipulation formEventManipulation = new FormEventManipulation();
                string eventName = eventListDelete.SelectedItem.ToString();
                string sqlDeleteEvent = $"DELETE FROM event WHERE event_name = '{eventName}'";
               
                MySqlCommand cmd = new MySqlCommand(sqlDeleteEvent, FormMain.mySqlConnection);
                cmd.ExecuteNonQuery();
                formEventManipulation.receiveDataDelete(eventName);
                MessageBox.Show("Event Deletion Sucessfull", "Event Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();


            }
            catch (MySqlException msqlex)
            {
                MessageBox.Show("Database Error", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
            }


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

        private void btnDeleteCancel_MouseHover(object sender, EventArgs e)
        {
            btnDeleteCancel.BackColor = Color.MediumPurple;
            btnDeleteCancel.ForeColor = Color.White;
        }

        private void btnDeleteCancel_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteCancel.BackColor = Color.Gainsboro;
            btnDeleteCancel.ForeColor = Color.Black;
        }

        private void btnDeleteOK_MouseHover(object sender, EventArgs e)
        {
            btnDeleteOK.BackColor = Color.MediumPurple;
            btnDeleteOK.ForeColor = Color.White;
        }

        private void btnDeleteOK_MouseLeave(object sender, EventArgs e)
        {
            btnDeleteOK.BackColor = Color.Gainsboro;
            btnDeleteOK.ForeColor = Color.Black;
        }
    }
}

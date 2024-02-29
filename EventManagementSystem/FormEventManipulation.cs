using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EventManagementSystem
{
    public partial class FormEventManipulation : Form
    {
        public static ArrayList eventObjectList = new ArrayList();
        static ArrayList eventNames = new ArrayList();

        BindingSource bs = new BindingSource();
        public FormEventManipulation()
        {
            InitializeComponent();
        }

        public void receiveData(string eventName, string eventDate, string eventTime, string eventCapacity, string eventLoc, string eventDes, string em)
        {
            int capacity = Convert.ToInt32(eventCapacity);
            EventsClass eventsClass = new EventsClass(eventName, eventDate, eventTime, eventLoc, eventDes, capacity, em);
            eventObjectList.Add(eventsClass);
            string txt = eventName + " - " + em;
            eventNames.Add(txt);

        }
        public void receiveDataEdit(string eventName, string eventDate, string eventTime, string eventCapacity, string eventLoc, string eventDes, string em)
        {
            int capacity = Convert.ToInt32(eventCapacity);

            foreach (EventsClass val in eventObjectList)
            {
                if (val.EventName == eventName)
                {
                    val.EventEM = em;
                    val.EventTime = eventTime;
                    val.EventDate = eventDate;
                    val.EventDescription = eventDes;
                    val.EventLocation = eventLoc;
                    val.EventCapacity = capacity;
                    break;
                }
            }
            foreach (string val in eventNames)
            {
                if (val.Contains(eventName))
                {
                    string txt = eventName + " - " + em;
                    int myIndex = eventNames.IndexOf(val);
                    eventNames.RemoveAt(myIndex);
                    eventNames.Add(txt);
                    break;
                }
            }

        }

        public void receiveDataDelete(string eventName)
        {
            foreach (EventsClass val in eventObjectList)
            {
                if (val.EventName == eventName)
                {
                    eventObjectList.Remove(val);
                    break;
                }
            }
            foreach (string val in eventNames)
            {
                if (val.Contains(eventName))
                {
                    eventNames.Remove(val);
                    break;
                }
            }


        }



        private void btnEventAdd_Click(object sender, EventArgs e)
        {
            FormEventAdd formEventAdd = new FormEventAdd();
            formEventAdd.ShowDialog();

        }

        private void FormEventManipulation_Load(object sender, EventArgs e)
        {
            bs.DataSource = eventNames;
            eventList.DataSource = bs;
        }

        private void FormEventManipulation_Activated(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
        }

        private void btnEventEdit_Click(object sender, EventArgs e)
        {
            FormEventEdit formEventEdit = new FormEventEdit();
            formEventEdit.ShowDialog();

        }

        private void btnEventDelete_Click(object sender, EventArgs e)
        {
            FormEventDelete formEventDelete = new FormEventDelete();
            formEventDelete.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FormEventEMEdit formEMEdit = new FormEventEMEdit();
            //formEMEdit.ShowDialog();

            EMAfterLogin eMAfterLogin = new EMAfterLogin();
            eMAfterLogin.ShowDialog();
        }
    }
}

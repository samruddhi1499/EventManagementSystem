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
    public partial class FormRegister : Form
    {
        
        public static ArrayList attendeeObjectList = new ArrayList();
        BindingSource bs = new BindingSource();
        FormAttendeeHome attendeeHome = new FormAttendeeHome();

        private void FormRegister_Load(object sender, EventArgs e)
        {

            bs.DataSource = FormAttendeeHome.eventName;
        }

        public FormRegister()
        {

            InitializeComponent();
            
            eventName.Text = $"Event: {FormAttendeeHome.eventName}";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            FormAttendeeHome attendeeHome = new FormAttendeeHome();
            Attendees attendees = new Attendees(FormAttendeeHome.eventName, nameVal.Text, phoneval.Text, emailval.Text, student.Text);
            attendeeObjectList.Add(attendees);
            attendeeHome.getRegisteredEvent(FormAttendeeHome.eventName);
            MessageBox.Show("Event Registration Sucessfull", "Registration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void FormRegister_Activated(object sender, EventArgs e)
        {

        }
    }
}

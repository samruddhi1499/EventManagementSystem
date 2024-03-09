using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            validateFields(nameVal.Text, phoneval.Text, emailval.Text, student.Text);

        }


        public void validateFields(string name, string phone, string email, string studentno)
        {
            Regex regexName = new Regex("^[a-zA-Z]+$");
            int phoneNumber;
            if (nameVal.Text == "" || phoneval.Text == "" || emailval.Text == "" || student.Text == "")
            {
                MessageBox.Show(" You need to fill all the fields", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!regexName.IsMatch(nameVal.Text))
            {
                MessageBox.Show("Name should have only letters", "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(phoneval.Text, out phoneNumber))
            {
                MessageBox.Show("Phone number should have only numbers", "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!emailval.Text.Contains("@"))
            {
                MessageBox.Show("Invalid EmailId", "Invalid information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (EventsClass val in FormEventManipulation.eventObjectList)
                {
                    if (FormAttendeeHome.eventName == val.EventName.ToString())
                    {
                        val.EventCapacity -= 1;
                        MessageBox.Show("Event Registration Sucessfull", "Registration Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        attendeeHome.addAttendee(FormAttendeeHome.eventName, nameVal.Text, phoneval.Text, emailval.Text, student.Text);
                        attendeeHome.getRegisteredEvent(FormAttendeeHome.eventName);

                        this.Close();
                    }

                }

            }
        }

        //private void Close_MouseHover(object sender, EventArgs e)
        //{
        //    register.BackColor = Color.MediumPurple;
        //    register.ForeColor = Color.White;
        //}

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            register.BackColor = Color.Gainsboro; ;
            register.ForeColor = Color.Black;
        }

        private void register_MouseHover(object sender, EventArgs e)
        {
            register.BackColor = Color.MediumPurple;
            register.ForeColor = Color.White;

        }

        private void register_MouseLeave(object sender, EventArgs e)
        {
            register.BackColor = Color.Gainsboro; ;
            register.ForeColor = Color.Black;
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            register.BackColor = Color.MediumPurple;
            register.ForeColor = Color.White;
        }
    }
}

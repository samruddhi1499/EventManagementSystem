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
    public partial class FormSelectRole : Form
    {
        public static ArrayList eventObjectList = new ArrayList();
        static ArrayList roleNames = new ArrayList();
        BindingSource bs = new BindingSource();

        public FormSelectRole()
        {
            InitializeComponent();
        }

        public void receiveData(string name, string ar)
        {
            addRoleClass addroleClass = new addRoleClass(name, ar);
            eventObjectList.Add(addroleClass);
            string txt = name + " - " + ar;
            roleNames.Add(txt);
            addList.Items.Add(txt);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //public void receiveData(string name, string addRole)
        //{
        //    EventsClass eventsClass = new EventsClass(eventName, eventDate, eventTime, eventLoc, eventDes, capacity, em);
        //    eventObjectList.Add(eventsClass);
        //    string txt = eventName + " - " + em;
        //    eventNames.Add(txt);

        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                string ar = selectRole.SelectedItem.ToString();
                receiveData(name.Text, ar);
                MessageBox.Show("Event Addition Sucessfull", "Event Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Check field", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void FormSelectRole_Load(object sender, EventArgs e)
        {
            bs.DataSource = roleNames;
            addList.DataSource = bs;
        }

        private void addList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminHome home = new FormAdminHome();   
            this.Close();
            home.Show();
        }
    }
}

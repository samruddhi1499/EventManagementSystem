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
    public partial class editRole : Form
    {
        public editRole()
        {
            InitializeComponent();
        }

        private void selectRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selecteValue = selectRole.SelectedItem.ToString();

            ArrayList arrayList = FormSelectRole.eventObjectList;
            foreach (addRoleClass array in arrayList)
            {
                if (selecteValue == array.Name.ToString())
                {

                    selectRole.Text = array.Role.ToString();
                    break;
                }
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            FormSelectRole formSelectRole = new FormSelectRole();
            //    string selectName = name.ToString();
            string selectrole = selectRole.SelectedItem.ToString();

            try
            {
               // formSelectRole.receiveDataEdit(name.Text, selectrole);
                MessageBox.Show("Event Edit Sucessfull", "Event Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check Capacity", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void editRole_Load(object sender, EventArgs e)
        {
            ArrayList arrayList = FormSelectRole.eventObjectList;


            foreach (addRoleClass array in arrayList)
            {
                addRoleClass roleClass = (addRoleClass)array;
                selectRole.Items.Add(roleClass.Name.ToString());
            }
            addRoleClass roleClass1 = (addRoleClass)arrayList[0];
            selectRole.Text = roleClass1.Name.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void selectRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class FormSelectRole : Form
    {




        public static ArrayList eventObjectList = new ArrayList();
        static ArrayList roleNames = new ArrayList();
        BindingSource bs = new BindingSource();

        public string Role { get; private set; }
        public string Name { get; private set; }



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

        public void receiveDataEdit(string selectName, string selectRole)
        {
            foreach (addRoleClass insert in eventObjectList)
            {
                if (insert.Name == selectName /*&& insert.Role == selectRole*/)
                {
                    insert.Name = selectName;
                    insert.Role = selectRole;
                    break;
                }
            }
            foreach (string insert in roleNames)
            {
                string txt = selectName + " - " + selectRole;
                int myIndex = roleNames.IndexOf(insert);
                roleNames.RemoveAt(myIndex);
                roleNames.Add(txt);
                break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Name = name.Text;
            Role = selectRole.Text;

            int count = 0;
            bool deleted = false;
            foreach (addRoleClass role in eventObjectList)
            {
                if (role.Name.ToString() == name.Text && role.Role.ToString() == selectRole.Text)
                {
                    eventObjectList.RemoveAt(count);
                    addList.Items.Remove($"{name.Text} - {selectRole.Text}");
                    deleted = true;
                    break;
                }
                count++;
            }
            if (deleted)
            {
                MessageBox.Show("UserRole Deleted", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("User not present", "Invalid attendee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            name.ResetText();
            selectRole.ResetText();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            Name = name.Text;
            Role = selectRole.Text;

            try
            {

                string ar = selectRole.SelectedItem.ToString();
                receiveData(name.Text, ar);
                MessageBox.Show("Role Addition Sucessfull", "Role Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Check field", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            name.ResetText();
            selectRole.ResetText();


        }

        

        //private void FormSelectRole_Load(object sender, EventArgs e)
        //{
        //    bs.DataSource = roleNames;
        //    addList.DataSource = bs;
        //}


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

       

        private void FormSelectRole_Activated(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (addList.Items.Count == 0)
            {
                MessageBox.Show("No Events in List", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                editRole EditRole = new editRole();
                EditRole.ShowDialog();

            }
        }

    }
}

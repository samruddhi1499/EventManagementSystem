using Microsoft.VisualBasic.Logging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EventManagementSystem
{
    public partial class FormSelectRole : Form
    {
        public static ArrayList eventObjectList = new ArrayList();
        BindingSource bs = new BindingSource();
        addRoleClass? currentItem = null;

        public FormSelectRole()
        {
            InitializeComponent();
            SetControlsToDefault();
        }

        private void SetControlsToDefault()
        {
            btnAdd.Show();
            btnEdit.Hide();
            name.ResetText();
            selectRole.SelectedItem = null;
            currentItem = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleted = false;
            if (currentItem != null)
            {
                eventObjectList.Remove(currentItem);
                setListValues();
                deleted = true;
            }

            if (deleted)
            {
                MessageBox.Show("UserRole Deleted", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User not present", "Invalid attendee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetControlsToDefault();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string ar = Convert.ToString(selectRole.SelectedItem);
                AddEditData();
                MessageBox.Show("Role Added Sucessfully", "Role Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Check field", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (currentItem != null)
                {
                    currentItem.Name = name.Text;
                    currentItem.Role = Convert.ToString(selectRole.SelectedItem);
                    AddEditData();

                    MessageBox.Show("Role Edited Successfully", "Role Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void addList_DoubleClick(object sender, EventArgs e)
        {
            var SelectedItem = Convert.ToString(((ListBox)sender).SelectedItem);

            if (SelectedItem != null)
            {
                btnAdd.Hide();
                btnEdit.Show();



                foreach (addRoleClass item in eventObjectList)
                {
                    if ($"{item.Name} - {item.Role}" == SelectedItem)
                    {
                        currentItem = item;
                        name.Text = item.Name;
                        selectRole.SelectedItem = item.Role;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetControlsToDefault();
        }

        private void AddEditData()
        {
            if (currentItem == null)
            {
                addRoleClass addRoleClass = new addRoleClass(name.Text, Convert.ToString(selectRole.SelectedItem));
                eventObjectList.Add(addRoleClass);
            }

            setListValues();
            SetControlsToDefault();
        }

        private void setListValues()
        {
            addList.Items.Clear();
            foreach (addRoleClass item in eventObjectList)
            {
                addList.Items.Add($"{item.Name} - {item.Role}");
            }
        }

        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.MediumPurple;
            btnAdd.ForeColor = Color.White;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Gainsboro; ;
            btnAdd.ForeColor = Color.Black;
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.MediumPurple;
            btnEdit.ForeColor = Color.White;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Gainsboro; ;
            btnEdit.ForeColor = Color.Black;
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.MediumPurple;
            btnClear.ForeColor = Color.White;
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Gainsboro; ;
            btnClear.ForeColor = Color.Black;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.MediumPurple;
            btnDelete.ForeColor = Color.White;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Gainsboro; ;
            btnDelete.ForeColor = Color.Black;
        }
    }
}

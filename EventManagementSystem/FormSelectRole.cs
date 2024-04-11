using MySqlConnector;
using System.Collections;
using System.Data;

namespace EventManagementSystem
{
    public partial class FormSelectRole : Form
    {
        public static ArrayList userObjectList = new ArrayList();
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
            pass.Enabled = true;
            pass.Clear();
            label2.Enabled = true;
            selectRole.SelectedItem = null;
            currentItem = null;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleted = false;
            try
            {
                FormMain.mySqlConnection.Open();

                if (currentItem != null)
                {
                    // Delete the user from the database
                    if (DeleteUser(currentItem.Name))
                    {
                        userObjectList.Remove(currentItem);
                        setListValues();
                        deleted = true;
                        MessageBox.Show("UserRole Deleted", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setListValues(); // Refresh the list after deletion
                    }

                }
                else
                {
                    MessageBox.Show("User not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();
            }



            SetControlsToDefault();
        }
        private bool DeleteUser(string username)
        {
            try
            {
                string Delete_query = "DELETE FROM User WHERE username = @username ";
                //  string Delete_query = "DELETE FROM user WHERE username = @username AND role = @role";
                if (selectRole.Text == "EM")
                {
                    string selectQuery = $"Select event_name from event where event_manager = '{username}'";
                    MySqlCommand mySqlCommand = new MySqlCommand(selectQuery, FormMain.mySqlConnection);
                    MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("EM has assigned Event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    dataReader.Close();
                }
                if (selectRole.Text == "Attendee" || selectRole.Text == "EM")
                {
                    string selectQuery = $"Select event_name from attendeeregistration where username = '{username}'";
                    MySqlCommand mySqlCommand = new MySqlCommand(selectQuery, FormMain.mySqlConnection);
                    MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                    string event_name = "";
                    if (dataReader.HasRows)
                    {

                        while (dataReader.Read())
                        {
                            if (dataReader.HasRows && event_name != "")
                            {
                                event_name += ", ";
                            }

                            event_name += "'" + dataReader["event_name"] + "'";

                        }



                    }
                    dataReader.Close();
                    if (event_name != "")
                    {
                        string deleteAttendee = $"DELETE FROM attendeeregistration WHERE username = \"{username}\" AND event_name in ({event_name})";
                        MySqlCommand mySqlCommand1 = new MySqlCommand(deleteAttendee, FormMain.mySqlConnection);
                        mySqlCommand1.ExecuteNonQuery();
                        FormAttendeeHome formAttendeeHome = new FormAttendeeHome();
                        formAttendeeHome.LoadAllAttendee();
                        if (FormMain.mySqlConnection.State != ConnectionState.Open)
                            FormMain.mySqlConnection.Open();
                        string[] events = event_name.Split(",");
                        foreach (string s in events)
                        {
                            foreach (EventsClass val in FormEventManipulation.eventObjectList)
                            {
                                string item = "\'" + val.EventName.ToString() + "\'";
                                if (s == item)
                                {

                                    string updateCapacity = $"UPDATE event SET event_capacity =  {val.EventCapacity + 1} WHERE event_name = {s}";
                                    MySqlCommand mySqlUpdateCommand = new MySqlCommand(updateCapacity, FormMain.mySqlConnection);
                                    mySqlUpdateCommand.ExecuteNonQuery();
                                    val.EventCapacity += 1;
                                }
                            }

                        }

                    }


                }
                using (MySqlCommand cmd = new MySqlCommand(Delete_query, FormMain.mySqlConnection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleting user: " + ex.Message);
                throw new Exception("Unable to delete user");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain.mySqlConnection.Open();

                // Insert new user into the database
                if (InsertUser(name.Text, pass.Text, Convert.ToString(selectRole.SelectedItem)))
                {
                    AddEditData();
                    MessageBox.Show("Role Added Successfully", "Role Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    setListValues();
                    SetControlsToDefault();
                }
                else
                {
                    MessageBox.Show("Failed to add role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Check field", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                FormMain.mySqlConnection.Close();

            }

        }
        private bool InsertUser(string username, string password, string role)
        {
            try
            {
                string query = "INSERT INTO User (username, password, role) VALUES (@username, @password, @role)";
                using (MySqlCommand cmd = new MySqlCommand(query, FormMain.mySqlConnection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error inserting user: " + ex.Message);
                return false;
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
            try
            {
                FormMain.mySqlConnection.Open();

                if (currentItem != null)
                {
                    // Update the user's role in the database
                    if (UpdateUserRole(currentItem.Name, Convert.ToString(selectRole.SelectedItem)))
                    {
                        currentItem.Name = name.Text;
                        currentItem.Role = Convert.ToString(selectRole.SelectedItem);
                        AddEditData();
                        MessageBox.Show("Role Edited Successfully", "Role Edited", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //setListValues();
                        //SetControlsToDefault();
                    }
                    else
                    {
                        MessageBox.Show("Failed to edit role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                Console.WriteLine("Error Update");
            }
            finally
            {
                FormMain.mySqlConnection.Close();

            }

        }
        private bool UpdateUserRole(string username, string role)
        {
            try
            {
                string Update_query = $"UPDATE user SET role = '{role}' WHERE username = '{username}'";

                using (MySqlCommand cmd = new MySqlCommand(Update_query, FormMain.mySqlConnection))
                {

                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user role: " + ex.Message);
                return false;
            }
        }

        private void addList_DoubleClick(object sender, EventArgs e)
        {
            var SelectedItem = Convert.ToString(((ListBox)sender).SelectedItem);

            if (SelectedItem != null)
            {
                btnAdd.Hide();
                btnEdit.Show();
                pass.Enabled = false;
                label2.Enabled = false;



                foreach (addRoleClass item in userObjectList)
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
                userObjectList.Add(addRoleClass);
            }

            pass.Text = "";
            setListValues();
            SetControlsToDefault();
        }

        private void setListValues()
        {
            addList.Items.Clear();
            foreach (addRoleClass item in userObjectList)
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

        private void addList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormSelectRole_Load(object sender, EventArgs e)
        {
            //setListValues();
            LoadAllUser();

        }

        public void LoadAllUser()
        {
            FormMain.mySqlConnection.Open();
            userObjectList.Clear();
            string selectLoadSQL = "select * from user";
            MySqlCommand mySqlCommand = new MySqlCommand(selectLoadSQL, FormMain.mySqlConnection);
            MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader["username"].ToString() != "admin")
                {
                    string username = dataReader["username"] + "";
                    string password = dataReader["password"] + "";
                    string role = dataReader["role"] + "";
                    addRoleClass addRoleClass = new addRoleClass(username, role, password);
                    userObjectList.Add(addRoleClass);

                }
            }
            setListValues();
            FormMain.mySqlConnection.Close();
        }

    }
}

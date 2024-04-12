// Import necessary libraries
using MySqlConnector; // Library for MySQL database connection
using System.Collections; // Library for ArrayList
using System.Data; // Library for database operations

namespace EventManagementSystem
{
    // Partial class for selecting user roles
    public partial class FormSelectRole : Form
    {
        // Static array list to hold user objects
        public static ArrayList userObjectList = new ArrayList();
        BindingSource bs = new BindingSource();
        addRoleClass? currentItem = null; // Nullable variable to hold the current user item

        // Constructor
        public FormSelectRole()
        {
            InitializeComponent();
            SetControlsToDefault(); // Set controls to default state
        }

        // Set controls to default state
        private void SetControlsToDefault()
        {
            btnAdd.Show(); // Show add button
            btnEdit.Hide(); // Hide edit button
            name.ResetText(); // Reset name textbox
            pass.Enabled = true; // Enable password field
            pass.Clear(); // Clear password field
            label2.Enabled = true; // Enable label
            selectRole.SelectedItem = null; // Set selected item in role dropdown to null
            currentItem = null; // Reset current item
        }

        // Event handler for delete button click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool deleted = false;
            try
            {
                FormMain.mySqlConnection.Open(); // Open database connection

                if (currentItem != null) // Check if an item is selected
                {
                    // Delete the user from the database
                    if (DeleteUser(currentItem.Name))
                    {
                        userObjectList.Remove(currentItem); // Remove user from list
                        setListValues(); // Refresh the list
                        deleted = true;
                        MessageBox.Show("UserRole Deleted", "Deletion Completed", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message
                        setListValues(); // Refresh the list after deletion
                    }

                }
                else
                {
                    MessageBox.Show("User not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
            }
            finally
            {
                FormMain.mySqlConnection.Close(); // Close database connection
            }

            SetControlsToDefault(); // Reset controls to default state
        }

        // Method to delete a user from the database
        private bool DeleteUser(string username)
        {
            try
            {
                string Delete_query = "DELETE FROM User WHERE username = @username "; // SQL query to delete user

                if (selectRole.Text == "EM") // Check if role is EM
                {
                    string selectQuery = $"Select event_name from event where event_manager = '{username}'"; // SQL query to check associated events
                    MySqlCommand mySqlCommand = new MySqlCommand(selectQuery, FormMain.mySqlConnection);
                    MySqlDataReader dataReader = mySqlCommand.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        MessageBox.Show("EM has assigned Event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                        return false;
                    }
                    dataReader.Close();
                }

                if (selectRole.Text == "Attendee" || selectRole.Text == "EM") // Check if role is Attendee or EM
                {
                    string selectQuery = $"Select event_name from attendeeregistration where username = '{username}'"; // SQL query to check registered events
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
                Console.WriteLine("Error deleting user: " + ex.Message); // Log error message
                throw new Exception("Unable to delete user"); // Throw exception
            }
        }

        // Event handler for add button click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FormMain.mySqlConnection.Open();

                // Insert new user into the database
                if (InsertUser(name.Text, pass.Text, Convert.ToString(selectRole.SelectedItem)))
                {
                    AddEditData();
                    MessageBox.Show("Role Added Successfully", "Role Added", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message
                    setListValues(); // Refresh the list
                    SetControlsToDefault(); // Reset controls to default state
                }
                else
                {
                    MessageBox.Show("Failed to add role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                }
            }
            catch
            {
                MessageBox.Show("Check field", "Invalid Type ", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
            }
            finally
            {
                FormMain.mySqlConnection.Close(); // Close database connection
            }
        }

        // Method to insert a new user into the database
        private bool InsertUser(string username, string password, string role)
        {
            try
            {
                string query = "INSERT INTO User (username, password, role) VALUES (@username, @password, @role)"; // SQL query to insert user
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
                Console.WriteLine("Error inserting user: " + ex.Message); // Log error message
                return false;
            }
        }

        // Event handler for logout menu item click
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogIn formLogIn = new FormLogIn();
            this.Close();
            formLogIn.Show();
        }

        // Event handler for home menu item click
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdminHome home = new FormAdminHome();
            this.Close();
            home.Show();
        }

        // Event handler for form activation
        private void FormSelectRole_Activated(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
        }

        // Event handler for edit button click
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
                        MessageBox.Show("Role Edited Successfully", "Role Edited", MessageBoxButtons.OK, MessageBoxIcon.Information); // Show success message
                    }
                    else
                    {
                        MessageBox.Show("Failed to edit role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                    }
                }
                else
                {
                    MessageBox.Show("User not selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Show error message
                }
            }
            catch
            {
                Console.WriteLine("Error Update"); // Log error message
            }
            finally
            {
                FormMain.mySqlConnection.Close(); // Close database connection
            }
        }

        // Method to update user's role in the database
        private bool UpdateUserRole(string username, string role)
        {
            try
            {
                string Update_query = $"UPDATE user SET role = '{role}' WHERE username = '{username}'"; // SQL query to update user role

                using (MySqlCommand cmd = new MySqlCommand(Update_query, FormMain.mySqlConnection))
                {
                    cmd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating user role: " + ex.Message); // Log error message
                return false;
            }
        }

        // Event handler for double click on listbox
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

        // Event handler for clear button click
        private void btnClear_Click(object sender, EventArgs e)
        {
            SetControlsToDefault();
        }

        // Method to add or edit user data
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

        // Method to set values in the listbox
        private void setListValues()
        {
            addList.Items.Clear();
            foreach (addRoleClass item in userObjectList)
            {
                addList.Items.Add($"{item.Name} - {item.Role}");
            }
        }

        // Event handler for edit profile menu item click
        private void editProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditProfile formEditProfile = new FormEditProfile();
            formEditProfile.ShowDialog();
        }

        // Event handlers for button mouse hover and leave events
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.MediumPurple; // Change button background color
            btnAdd.ForeColor = Color.White; // Change button text color
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Gainsboro; // Change button background color
            btnAdd.ForeColor = Color.Black; // Change button text color
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.MediumPurple; // Change button background color
            btnEdit.ForeColor = Color.White; // Change button text color
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Gainsboro; // Change button background color
            btnEdit.ForeColor = Color.Black; // Change button text color
        }

        private void btnClear_MouseHover(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.MediumPurple; // Change button background color
            btnClear.ForeColor = Color.White; // Change button text color
        }

        private void btnClear_MouseLeave(object sender, EventArgs e)
        {
            btnClear.BackColor = Color.Gainsboro; // Change button background color
            btnClear.ForeColor = Color.Black; // Change button text color
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.MediumPurple; // Change button background color
            btnDelete.ForeColor = Color.White; // Change button text color
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Gainsboro; // Change button background color
            btnDelete.ForeColor = Color.Black; // Change button text color
        }

        private void addList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Event handler for form load
        private void FormSelectRole_Load(object sender, EventArgs e)
        {
            LoadAllUser(); // Load all users
        }

        // Method to load all users
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

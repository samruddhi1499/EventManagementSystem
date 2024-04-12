using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySqlConnector;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    // Main form of the application
    public partial class FormMain : Form
    {
        // Database instance
        public Database MYDB;

        // MySqlConnection instance
        public static MySqlConnection mySqlConnection;

        // Constructor
        public FormMain()
        {
            InitializeComponent();
        }

        // Event handler for login button click
        private void login_Click(object sender, EventArgs e)
        {
            FormLogIn formLogin = new FormLogIn();
            formLogin.Show();
            this.Hide();
        }

        // Event handler for signup button click
        private void signup_Click(object sender, EventArgs e)
        {
            FormSignUp formSignUp = new FormSignUp();
            formSignUp.Show();
            this.Hide();
        }

        // Event handlers for hover effects on buttons
        private void login_MouseHover(object sender, EventArgs e)
        {
            login.BackColor = Color.MediumPurple;
            login.ForeColor = Color.White;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.BackColor = Color.Gainsboro;
            login.ForeColor = Color.Black;
        }

        private void signup_MouseHover(object sender, EventArgs e)
        {
            signup.BackColor = Color.MediumPurple;
            signup.ForeColor = Color.White;
        }

        private void signup_MouseLeave(object sender, EventArgs e)
        {
            signup.BackColor = Color.Gainsboro;
            signup.ForeColor = Color.Black;
        }

        // Event handler for form load event
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Initialize database connection
            MYDB = new Database("localhost", "root", "S@mmy123", "event_management", "3306");
            mySqlConnection = MYDB.Connect();

            // Load necessary data on form load
            FormEventManipulation formEventManipulation = new FormEventManipulation();
            FormAttendeeHome formAttendeeHome = new FormAttendeeHome();
            FormSelectRole formSelectRole = new FormSelectRole();
            formEventManipulation.LoadAll();
            formEventManipulation.LoadAllEM();
            formAttendeeHome.LoadAllAttendee();
            formSelectRole.LoadAllUser();
        }
    }
}

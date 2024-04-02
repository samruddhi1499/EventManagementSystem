using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using Microsoft.VisualBasic;

namespace EventManagementSystem
{
    

    // Class representing a database connection
    public class Database
    {
        // Properties for database connection parameters
        public String ServerAddress { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public String DatabaseName { get; set; }
        public String PortNumber { get; set; }

        // Constructor to initialize database connection parameters
        public Database(string serverAddress, string userName, string password, string databaseName, string portNumber)
        {
            ServerAddress = serverAddress;
            UserName = userName;
            Password = password;
            DatabaseName = databaseName;
            PortNumber = portNumber;
        }

        // Method to establish a database connection
        public MySqlConnection Connect()
        {
            // Build connection string using connection parameters
            String connStr = $"Server={this.ServerAddress};port={this.PortNumber};User id={this.UserName};Password={this.Password};Database={this.DatabaseName}";
            try
            {
                // Create MySqlConnection object with the connection string
                MySqlConnection conn = new MySqlConnection(connStr);
                return conn;
            }
            catch (Exception ex)
            {
                // Display error message if connection fails
                MessageBox.Show("Error in Connecting to database" + ex.Message);
                return null;
            }
        }
    }
}


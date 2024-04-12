using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    // Class to represent user roles
    class addRoleClass
    {
        // Properties
        public string Name { get; set; } // User name
        public string Password { get; set; } // User password
        public string Role { get; set; } // User role

        // Constructor for user with no password
        public addRoleClass(string name, string role)
        {
            Name = name;
            Role = role;
        }

        // Constructor for user with password
        public addRoleClass(string name, string role, string pass)
        {
            Name = name;
            Role = role;
            Password = pass;
        }

        // ToString method to represent object as a string
        public String ToString()
        {
            String s = $"Id: {Name}";
            return s;
        }
    }
}

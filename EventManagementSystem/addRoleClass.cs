using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    class addRoleClass
    {
        public string Name { get; set; }
        public string Role { get; set; }


        public addRoleClass(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public String ToString()
        {
            String s = $"Id: {Name}";
            return s;
        }

      
    }
}

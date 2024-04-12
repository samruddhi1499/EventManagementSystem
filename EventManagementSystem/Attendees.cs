using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    // Class to represent attendees of an event
    class Attendees
    {
        // Properties
        public string EventName { get; set; } // Name of the event
        public string Username { get; set; } // Username of the attendee
        public string AttendeeName { get; set; } // Name of the attendee
        public string Phone { get; set; } // Phone number of the attendee
        public string Emailid { get; set; } // Email ID of the attendee
        public string Studentno { get; set; } // Student number of the attendee

        // Constructor for attendee with basic details
        public Attendees(string eventName, string username, string attendeeName)
        {
            EventName = eventName;
            Username = username;
            AttendeeName = attendeeName;
        }

        // Constructor for attendee with detailed information
        public Attendees(string eventName, string userName, string attendeeName, string phone, string emailid, string studentno)
        {
            EventName = eventName;
            Username = userName;
            AttendeeName = attendeeName;
            Phone = phone;
            Emailid = emailid;
            Studentno = studentno;
        }

        // Constructor for attendee with only name
        public Attendees(string attendeeName)
        {
            AttendeeName = attendeeName;
        }

        // ToString method to represent object as a string
        override
        public String ToString()
        {
            String s = $"Attendee: {AttendeeName}";
            return s;
        }

        // Implicit conversion from ArrayList to Attendees (Not implemented)
        public static implicit operator Attendees(ArrayList v)
        {
            throw new NotImplementedException();
        }
    }
}

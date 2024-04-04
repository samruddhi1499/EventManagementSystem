using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
     class Attendees
    {
        public string EventName { get; set; }
        public string Username { get; set; }
        public string AttendeeName { get; set; }
        public string Phone { get; set; }
        public string Emailid { get; set; }
        public string Studentno { get; set; }

        public Attendees(string eventName, string username, string attendeeName)
        {

            EventName = eventName;
            Username = username;
            AttendeeName = attendeeName;
        }
        public Attendees(string eventName, string userName, string attendeeName, string phone, string emailid, string studentno)
        {

            EventName = eventName;
            Username = userName;
            AttendeeName = attendeeName;
            Phone = phone;
            Emailid = emailid;
            Studentno = studentno;
        }
        public Attendees(string attendeeName)
        {
            AttendeeName = attendeeName;
        }

        override
        public String ToString()
        {
            String s = $"Attendee: {AttendeeName}";
            return s;
        }

        public static implicit operator Attendees(ArrayList v)
        {
            throw new NotImplementedException();
        }
    }
}

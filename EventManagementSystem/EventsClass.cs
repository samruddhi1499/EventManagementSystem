using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EventManagementSystem
{
    // Class to represent events
    class EventsClass
    {
        // Properties
        public string EventName { get; set; } // Name of the event
        public string EventDate { get; set; } // Date of the event
        public string EventTime { get; set; } // Time of the event
        public string EventLocation { get; set; } // Location of the event
        public string EventDescription { get; set; } // Description of the event
        public int EventCapacity { get; set; } // Capacity of the event
        public string EventEM { get; set; } // Event Manager

        // Constructor for event with all details
        public EventsClass(string eventName, string eventDate, string eventTime, string eventLocation, string eventDescription, int eventCapacity, string eventEM)
        {
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            EventLocation = eventLocation;
            EventDescription = eventDescription;
            EventCapacity = eventCapacity;
            EventEM = eventEM;
        }

        // Constructor for event with only name
        public EventsClass(string eventName)
        {
            EventName = eventName;
        }

        // ToString method to represent object as a string
        override
        public String ToString()
        {
            String s = $"Id: {EventName}";
            return s;
        }

        // Implicit conversion from ArrayList to EventsClass (Not implemented)
        public static implicit operator EventsClass(ArrayList v)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EventManagementSystem
{

    class EventsClass
    {
        
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string EventTime { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public int EventCapacity { get; set; }
        public string EventEM {  get; set; }

        public EventsClass(string eventName, string eventDate, string eventTime, string eventLocation, string eventDescription, int eventCapacity, string eventEM) {
        
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            EventLocation = eventLocation;
            EventDescription = eventDescription;
            EventCapacity = eventCapacity;
            EventEM = eventEM;
        }
        public EventsClass(string eventName)
        {
            EventName = eventName;
        }

        override
        public String ToString()
        {
            String s = $"Id: {EventName}";
            return s;
        }

        public static implicit operator EventsClass(ArrayList v)
        {
            throw new NotImplementedException();
        }
    }
}

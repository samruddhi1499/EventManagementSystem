using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManagementSystem
{
    class Event
    {
        public string EventName { get; set; }
        public string EventDate { get; set; }
        public string EventTime { get; set; }
        public string EventLocation { get; set; }
        public string EventDescription { get; set; }
        public int EventCapacity { get; set; }
        public string EventEM {  get; set; }

        public Event(string eventName, string eventDate, string eventTime, string eventLocation, string eventDescription, int eventCapacity, string eventEM) {
        
            EventName = eventName;
            EventDate = eventDate;
            EventTime = eventTime;
            EventLocation = eventLocation;
            EventDescription = eventDescription;
            EventCapacity = eventCapacity;
            EventEM = eventEM;
        }
    }
}

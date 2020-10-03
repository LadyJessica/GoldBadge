using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoOutings
{
    
    public class EventClass
    {
        public string EventName { get; set; }
        public int EventCount { get; set; }
        public decimal EventPersonCost { get; set; } //don't forget m!
        public DateTime EventDate { get; set; } 
        public decimal EventTotalCost { get { return EventCount * EventPersonCost;  } }
        public EventType TypeOfEvent { get; set; }

        public enum EventType
        {
            Golf = 1,
            Bowling = 2,
            AmusementPark = 3,
            Concert = 4,
        }

        public EventClass() { }

        public EventClass(string eventName, int eventCount, decimal eventPerPerson, DateTime eventDate, EventType eventType)
        {
            EventName = eventName;
            EventCount = eventCount;
            EventPersonCost = eventPerPerson;
            EventDate = eventDate;
            TypeOfEvent = eventType;


        }
    }
}

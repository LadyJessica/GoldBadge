using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoOutings
{
    public class EventRepo
    {
        //create event

        public List<EventClass> _outingList = new List<EventClass>();

        public void CreateNewEvent(EventClass newEvent)
        {
            _outingList.Add(newEvent);
        }

        // read out events

        public List<EventClass> GetEventList()
        {
            return _outingList;
        }

        //total costs

        public decimal GetTotalCost()
        {
            decimal grandTotal = 0.0m;

            foreach (EventClass eventClass in _outingList)
            {
                grandTotal += eventClass.EventTotalCost;
            }
            return grandTotal;

        }

        //cost by event - pull helper and for each do total cost

        public decimal TotalCostByType(int eventType)
        {
            List<EventClass> eventTypeList = new List<EventClass>();
            decimal typeGrandTotal = 0.0m;
            foreach (EventClass eventClass in _outingList)
            {
                if ((int)eventClass.TypeOfEvent == eventType)
                {
                    eventTypeList.Add(eventClass);
                }
            }
            foreach(EventClass cost in eventTypeList)
            {
                typeGrandTotal += cost.EventTotalCost;
            }
            return typeGrandTotal;
        }
        

        //helper - by type
        public List<EventClass> GetOutingByType(int outingType)
        {
            List<EventClass> eventTypeList = new List<EventClass>();
            foreach (EventClass outing in _outingList)
            {
                if (outing.TypeOfEvent.Equals(outingType))
                {
                    eventTypeList.Add(outing);
                }
            }
            return eventTypeList;
        }

    }
}

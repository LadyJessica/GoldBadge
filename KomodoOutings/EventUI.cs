using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoOutings
{
    public class EventUI
    {
        //repo link
        EventRepo _eventRepo = new EventRepo();

        public void Run()
        {
            Seed();
            Event();
           
        }

        public void Event()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome Admin. Please select an to option:\n" +
                    "1. See event list \n" +
                    "2. Add an event\n" +
                    "3. Cost of all outtings\n" +
                    "4. Cost by event type\n" +
                    "0. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        ViewEventList();
                        break;

                    case "2":
                        AddEvent();
                        break;

                    case "3":
                        CostAllEvevnts();
                        break;

                    case "4":
                        CostByType();
                        break;

                    case "0": //exit
                        Console.WriteLine("Logging off");
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid number");
                        break;

                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void AddEvent()
        {
            Console.WriteLine("What type of vent to you wish to add?\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusment Park\n" +
                "4. Concert");

            string eventInput = Console.ReadLine();
            int outingParse = int.Parse(eventInput);

            EventClass.EventType eventType = (EventClass.EventType)Enum.ToObject(typeof(EventClass.EventType), outingParse);


            Console.WriteLine("Enter the name of the outting.");
            string eventName = Console.ReadLine();

            Console.WriteLine("How many people are attending?");
            int peopleAttending = int.Parse(Console.ReadLine());

            Console.WriteLine("When is the event? Format: YYYY, MM, DD");
            DateTime dateOnly = DateTime.Parse(Console.ReadLine());
            DateTime dateEntry = dateOnly.Date;

            Console.WriteLine("What is the cost per person?");
            decimal costPerPerson = decimal.Parse(Console.ReadLine());

            EventClass newEvent = new EventClass(eventName, peopleAttending, costPerPerson, dateOnly, eventType);
            _eventRepo.CreateNewEvent(newEvent);
        }

        private void ViewEventList()
        {
            List<EventClass> listOfEvents = _eventRepo.GetEventList();

            foreach(EventClass outing in listOfEvents)
            {
                Console.WriteLine($"Name: {outing.EventName}\n" +
                    $"Type: {outing.TypeOfEvent}\n" +
                    $"Attendence: {outing.EventCount}\n" +
                    $"Admitance Cost: {outing.EventPersonCost}\n" +
                    $"Total Cost: {outing.EventTotalCost}\n\n");
            }

        }

        private void CostAllEvevnts()
        {
            Console.WriteLine(_eventRepo.GetTotalCost()) ;
        }

        private void CostByType()
        {
            Console.WriteLine("Please select an event type you wish to see the total cost for:\n" +
                "1.Golf\n" +
                "2. Bowling\n" +
                "3. Amusment Park\n" +
                "4. Concert");

            int eventType = int.Parse(Console.ReadLine());

            if (eventType < 0)
            {
                Console.WriteLine("Invalid selection");
                            }

            else
            {
                Console.WriteLine("Total cost for event selected is: ");
                Console.WriteLine(_eventRepo.TotalCostByType(eventType));
            }
        }


        private void Seed()
        { //name, type, count, cost, date
            _eventRepo.CreateNewEvent(new EventClass("Blackout Minigolf", 23, 11.50m, new DateTime(2020, 7, 14), EventClass.EventType.Golf));
            _eventRepo.CreateNewEvent(new EventClass("Inverarry Golf", 8, 8.50m, new DateTime(2020, 6, 14), EventClass.EventType.Golf));
            _eventRepo.CreateNewEvent(new EventClass("King's Island", 32, 25.75m, new DateTime(2020, 5, 4), EventClass.EventType.AmusementPark));
            _eventRepo.CreateNewEvent(new EventClass("Holiday World", 15, 10.00m, new DateTime(2020, 10, 30), EventClass.EventType.AmusementPark));
            _eventRepo.CreateNewEvent(new EventClass("Backstreet Boys", 10, 150.35m, new DateTime(2020, 8, 1), EventClass.EventType.Concert));
            _eventRepo.CreateNewEvent(new EventClass("KISS", 32, 115.30m, new DateTime(2020, 9, 28), EventClass.EventType.Concert));
            _eventRepo.CreateNewEvent(new EventClass("Sunrise Bowling", 35, 5.50m, new DateTime(2020, 1, 13), EventClass.EventType.Bowling));
            _eventRepo.CreateNewEvent(new EventClass("Pizza and Bowling", 15, 8.50m, new DateTime(2020, 2, 13), EventClass.EventType.Bowling));

        }

    }
}

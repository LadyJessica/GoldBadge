using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeFinal
{
    class BadgeUI
    {
        BadgeRepo _badgeRepo = new BadgeRepo();

        public void Menu()
        {

            bool keepRunning = true;
            while (keepRunning)
            {

                Console.WriteLine("Welcome Admin. Please select an to option:\n" +
                    "1. Create New Badge\n" +
                    "2. Add door to existing badge\n" +
                    "3. Update doors on badge\n" +
                    "4. View Badge\n" +
                    "5. Reset badge (deletes all door access)\n" +
                    "6. Delete badge\n" +
                    "0. Exit");

                //input

                string input = Console.ReadLine();

                switch (input)
                {
                    //new badge
                    case "1":
                        CreateNewBadge();
                        break;

                    case "2": //add door
                        AddDoorToBadge();
                        break;

                    case "3": //update door
                        UpdateDoor();
                        break;

                    case "4": //view badge
                        BadgeList();
                        break;

                    case "5": //delete all doors on badge
                        DeleteAllDoors();
                        break;

                    case "6": //delete badge
                        DeleteBadge();
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

        //create new badge

        private void CreateNewBadge()
        {
            Console.WriteLine("Please enter the badge name.");
            string badgeName = Console.ReadLine();

            Console.WriteLine("Please enter the badge ID number.");
            int badgeID = int.Parse(Console.ReadLine());

            Badge newBadge = new Badge(badgeID, badgeName);

            _badgeRepo.AddBadgeDictionary(badgeID, newBadge);

            Console.WriteLine("Badge has been creatd");
        }

        private void AddDoorToBadge()
        {
            Console.WriteLine("Please enter badge ID");
            int badgeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter door you would like to add. Only one entry at can added at a time");
            string addDoorName = Console.ReadLine();

            _badgeRepo.AddDoorToBadge(addDoorName, badgeID);
        }

        private void UpdateDoor()
        {
            Console.WriteLine("Please enter badge ID");
            int badgeID = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter badge's new name");
            //string badgeName = Console.ReadLine();

            Console.WriteLine("Please enter a door name");
            string doorName = Console.ReadLine();

            _badgeRepo.UpdateBadge(badgeID, doorName);

        }

        private void BadgeList()
        {
            Console.WriteLine("Listing all badges: \n\n\n");

            Dictionary<int, Badge> AllBadges = _badgeRepo.GetAllBadges();
            
            foreach(var item in AllBadges)
            {
                Console.WriteLine($"Badge ID: {item.Value.BadgeID}\n +" +
                    $"Badge Name: {item.Value.BadgeName}");

                Console.WriteLine("Doors on Badge");
                foreach(var door in item.Value.DoorList)
                {
                    Console.WriteLine(door);
                }
            }
                      
        }

        private void DeleteAllDoors()
            {
            Console.WriteLine("Please enter Badge ID that you wish to delete all doors from");
            int badgeID = int.Parse(Console.ReadLine());

            _badgeRepo.DeleteRoomsOnBadge(badgeID);

        }

        private void DeleteBadge()
        {
            Console.WriteLine("Please enter Badge ID that you wish to delete all doors from");
            int badgeID = int.Parse(Console.ReadLine());

            _badgeRepo.DeleteDictionaryItem(badgeID);
        }
        
}
}    

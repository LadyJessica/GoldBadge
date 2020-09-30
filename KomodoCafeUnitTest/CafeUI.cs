using KomodoCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafeUnitTest
{
   public class CafeUI
    {
        MenuRepo _menuRepo = new MenuRepo();
        public void Run()
        {

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Welcome Admin. Please select an to option:\n" +
                    "1. Create menu item \n" +
                    "2. Delete menu item\n" +
                    "3. View all menu items\n" +
                    "0. Exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        CreateNewMenuItem();
                        break;

                    case "2": //add door
                        DeleteMenuItem();
                        break;

                    case "3": //update door
                        ViewAllItems();
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
        private void CreateNewMenuItem()
        {
            CafeMenu newItem = new CafeMenu();

            Console.WriteLine("Please enter the name of the new item");
            newItem.MealName = Console.ReadLine();

            Console.WriteLine("Please enter new meal number");
            string mealNumberAsString = Console.ReadLine();
            newItem.MenuNumber = int.Parse(mealNumberAsString);

            Console.WriteLine("Please enter meal description");
            newItem.MealDescription = Console.ReadLine();

            Console.WriteLine("Please enter meal ingredients");
            newItem.Ingredietns = Console.ReadLine();

            Console.WriteLine("Please enter meal cost as a decimal");
            string costAsString = Console.ReadLine();
            newItem.Price = int.Parse(costAsString);
        }
        private void DeleteMenuItem()
        {
            Console.WriteLine("Please enter a meal number to delete the item");
            int menuNumber = int.Parse(Console.ReadLine());

            bool wasDeleted = _menuRepo.DeleteMenuItem(menuNumber);

            if(wasDeleted)
            {
                Console.WriteLine("Item deleted");
            }
            else
            {
                Console.WriteLine("Item not found, try again");
            }

        }
        private void ViewAllItems()
        {
            Console.WriteLine("Listing all Menu Items:\n\n\n");

            List<CafeMenu> AllItems = _menuRepo.GetCafeMenu();

            foreach(var item in AllItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    public class CafeMenu
    {

        public int MenuNumber { get; set; }
        public string MealName { get; set; }
        public string MealDescription { get; set; }
        public string Ingredietns { get; set; }
        public decimal Price { get; set; }

        public CafeMenu() { }

        public CafeMenu(int menuNumber, string mealName, string mealDescription, string ingredients, decimal price)
        {
            MenuNumber = menuNumber;
            MealName = mealName;
            MealDescription = mealDescription;
            Ingredietns = ingredients;
            Price = price;
        }
    }



}

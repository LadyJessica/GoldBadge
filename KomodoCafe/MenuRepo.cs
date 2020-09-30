using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
  public  class MenuRepo
    {
        public List<CafeMenu> _cafeMenu = new List<CafeMenu>();
        //create
        public void CreateNewMenuItem(CafeMenu menuItem) 
        {
            _cafeMenu.Add(menuItem);
        }

        //read

        public List<CafeMenu> GetCafeMenu()
        {
            return _cafeMenu;
        }

        //delete

        public bool DeleteMenuItem(int menuNumber)
        {
            CafeMenu menuItem = GetMenuItemByNumber(menuNumber);

            if(menuItem == null)
            {
                _cafeMenu.Remove(menuItem);
                return true;
            }
            else
            {
                return false;
            }
        }

        //helper

        public CafeMenu GetMenuItemByNumber(int menuNumber)
        {
            foreach (CafeMenu cafeMenu in _cafeMenu)
            {
                if (cafeMenu.MenuNumber == menuNumber)
                {
                    return cafeMenu;
                }
            }
            return null;
        }
    }
}

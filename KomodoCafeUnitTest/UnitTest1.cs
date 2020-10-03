using System;
using KomodoCafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KomodoCafeUnitTest
{
    [TestClass]
 
    public class UnitTest1
    {
        MenuRepo _menuRepo = new MenuRepo();

        [TestMethod]

        public void AddMenuItem_Test()
        {
            //arrange
            CafeMenu actual;
            int menuNumber = 2;
            CafeMenu menuItem = new CafeMenu(1, "Sunrise Surprise", "Burger with egg", "Beef, egg, tomato, avocado", 10);

            //act

            _menuRepo.CreateNewMenuItem(menuItem);
            actual = _menuRepo.GetMenuItemByNumber(menuNumber);

            //assert

            Assert.IsNotNull(actual);
        }
        
    }
}

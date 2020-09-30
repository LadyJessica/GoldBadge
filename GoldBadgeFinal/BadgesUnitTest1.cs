using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoldBadgeFinal
{
    [TestClass]
    public class BadgesUnitTest1
            //have a test for each method in repo
            //arrange, act, assert
    {
        BadgeRepo _badgeRepo = new BadgeRepo();
       
        [TestMethod]
        
        public void AddBadgeDictionary_Test()
        {
            //arrange
            Badge actual;
            int badgeID = 1345; 
            Badge badge = new Badge(badgeID, "Front Door", new List<string> { "Front", "Lobby" });
            
            //act

            _badgeRepo.AddBadgeDictionary(badgeID, badge);
            actual = _badgeRepo.GetBadgeByID(badgeID);

            //assert

            Assert.IsNotNull(actual);
        }

        

    }
}

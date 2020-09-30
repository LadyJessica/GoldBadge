using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeFinal
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorList { get; set; }
        public string BadgeName { get; set; }

       
        public Badge() { }

        public Badge(int badgeID, string badgeName, List<string> doorName)
        {
            BadgeID = badgeID;
            BadgeName = badgeName;
            DoorList = doorName;
        }

        public Badge(int badgeID, string badgeName)
        {
            BadgeID = badgeID;
            BadgeName = badgeName;
            DoorList = new List<string>();
        }

    }
}

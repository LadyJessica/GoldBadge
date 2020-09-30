using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldBadgeFinal
{
    public class BadgeRepo
    {
      private  Dictionary<int, Badge> badgeDictionary = new Dictionary<int, Badge>();
       
        //CREATE
        public void AddBadgeDictionary(int badgeID, Badge newBadge)
        {
            badgeDictionary.Add(badgeID, newBadge);
        }

        public void AddDoorToBadge(string addDoorName, int badgeID)
        {
            Badge addDoor = GetBadgeByID(badgeID);
            addDoor.DoorList.Add(addDoorName);
        }

        //READ

        public Dictionary<int, Badge> GetAllBadges()
        {
            return badgeDictionary;

        }

                
       
        public List<string> DoorList(int badgeID)
        {
            Badge viewDoors = GetBadgeByID(badgeID);
            return viewDoors.DoorList;
        }

        //UPDATE

        public bool UpdateBadge(int badgeID, string doorName)
        {
            //find badge

            Badge oldBadge = GetBadgeByID(badgeID);

            //update badge

            if(oldBadge != null)
            {
                //oldBadge.BadgeID = newBadge.BadgeID;
               // oldBadge.BadgeName = newBadge.BadgeName;
                oldBadge.DoorList.Add(doorName);
                ///knows it's a string
                ///go to badge object, go to list object, do add method to this object
                
                return true;
            }
            else
            { return false; }
        }

       
        //DELETE

        public bool DeleteDictionaryItem(int badgeID)
        {
            //Badge deleteBadge = GetBadgeByID(badgeID);

            //if(deleteBadge == null)
            //{
            //    return false;
            //}

            //int initialCount = badgeDictionary.Count;
            //badgeDictionary.Remove(badgeID);

            //doesn't account for error checking - does badge exist?

            if (badgeDictionary.Count > 0)
            {
                badgeDictionary.Remove(badgeID);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteRoomsOnBadge(int badgeID)
        {
            Badge deleteRooms = GetBadgeByID(badgeID);

            if(deleteRooms == null)
            {
                return false;

            }

            deleteRooms.DoorList.Clear();
            return true;
        }

        //HELPER
        public Badge GetBadgeByID(int badgeID)
        {
            foreach (Badge badge in badgeDictionary.Values)

            {
                if (badge.BadgeID == badgeID)
                {
                    return badge;
                }


            }
            return null;   
                   
        }
    }

    

}

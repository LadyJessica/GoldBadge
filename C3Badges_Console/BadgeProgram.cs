using GoldBadgeFinal;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3Badges_Console
{
    class BadgeProgram
    {
       static void Main(string[] args)
        {
            //display menu
            BadgeUI badgeUI = new BadgeUI();

            badgeUI.Menu(); 

        }
    }
}

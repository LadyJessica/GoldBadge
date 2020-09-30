using KomodoCafeUnitTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoCafe
{
    /// <summary>
    /// what's needed
    /// menu
    ///     meal numbers
    ///     meal name
    ///     mean description
    ///     ingredients
    ///     price
    /// CRUD for menu items in Repo
    /// </summary>

    class KomodoProgram
    {
        static void Main(string[] args)
        {
            CafeUI cafeUI = new CafeUI();

            cafeUI.Run();
        }
    }
}

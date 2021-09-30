using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    // Q.2.2 Creation of abstract Base Class Character
    abstract class Character : Tile
    {
        // Variable Initialization
        protected int HP { get; set; }
        protected int MaxHP { get; set; }
        protected int Damage { get; set; }

        protected Tile[] characterVision = new Tile[4];

        public enum Movement
        {
            NONE,
            UP,
            DOWN,
            LEFT,
            Right
        }

    }
}

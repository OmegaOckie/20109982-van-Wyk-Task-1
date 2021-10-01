using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20109982_van_Wyk_POE
{
    //Q.3.1
    class Map
    {

        //Q.3.1 | Declare variables
        protected Tile[,] mapArray { get; set; }
        protected Hero myHero { get; set; }
        protected Enemy[] enemyArray { get; set; }
        protected int mapWidth { get; set; }
        protected int mapHeight { get; set; }
        protected Random rng { get; set; }
    }
}

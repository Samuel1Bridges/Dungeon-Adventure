using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Player
    {
        public string name;
        public string role;
        public int coins = 0;
        public int health = 10;
        public int damage = 1;
        public int magic = 0;
        public int magicDamage = 0;
        public int amourhealth = 0;
        public int potion;
        public int inventorySize = 10;
        public bool hints = true;
        public static int encounterchance = 100;


        public static void encounterchancedecress(int change)
        {
           encounterchance = change;
        }
        public static void encounterchanceincress(int change)
        {
            encounterchance = encounterchance +  change;
        }


    }




}

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
     class Floor1
    {

         public static void room1()
        {
            string roomdesc = $"As you enter the room the entrence to the cave you just came out of collapses you notice wooden boxes in the conner in on the " +
       "south west wall and on the on the north side there is a wooden door" +
       " and on the east side there is a long dark hallway";
            Random rnd = new Random();
           int randomnum = rnd.Next(0, 3);
            bool keeplooping = true;

               
            do
            {

                Console.Clear();
                Encounters.Pick(roomdesc , randomnum);
                Console.WriteLine("Type command");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "north":
                        room2();
                        keeplooping = false;
                        break;
                    case "east":
                        Console.WriteLine("You look at the cold damp wall and know you can't go that direction");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    case "south":
                        Console.WriteLine("Entrence collapsed can not enter");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    case "west":
                        Console.WriteLine("You look at the cold damp wall and know you can't go that direction");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Didn't type anything...");
                        Console.ReadLine();
                        break;
                }
            }while (keeplooping == true);
        }

        static public void room2()
        {
            string roomdesc = $"As you enter the room the entrence to the cave you just came out of collapses you notice wooden boxes in the conner in on the " +
                               "south west wall and on the on the north side there is a wooden door" +
                               " and on the east side there is a long dark hallway";
            Random rnd = new Random();
            int randomnum = rnd.Next(0, 3);
            bool keeplooping = true;

            do
            {
                Console.Clear();
                Encounters.Pick(roomdesc, randomnum);
                Console.WriteLine("Type command");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "north":
                        keeplooping = false;
                        break;
                    case "east":
                        Console.WriteLine("You look at the cold damp wall and know you can't go that direction");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    case "south":
                        room1();
                        keeplooping = false;
                        break;
                    case "west":
                        Console.WriteLine("You look at the cold damp wall and know you can't go that direction");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Didn't type anything...");
                        Console.ReadLine();
                        break;
                }
            } while (keeplooping == true);
        }

    }
}

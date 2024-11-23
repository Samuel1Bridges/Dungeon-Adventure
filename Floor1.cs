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
            string roomdesc = $"As you enter the room the entrence to the cave you just came out of "+
                                "collapses you notice wooden boxes in the conner in on the " +
                                "south west wall and on the on the north side there is a wooden door" +
                                " and on the east side there is a long dark hallway";
            Random rnd = new Random();
           int randomnum = rnd.Next(0, 3);
            bool keeplooping = true;

               
            do
            {

                Console.Clear();
                Encounters.Pick(roomdesc , randomnum);
                Console.WriteLine($"\n Type command");
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
                        Console.WriteLine("Invaild in put Type help if can't remeber commands");
                        Console.ReadLine();
                        break;
                }
            }while (keeplooping == true);
        }

        static public void room2()
        {
            string roomdesc = $"You enter the room its empty and quiet as you look around you can see markings \n on the west wall and 2 door ways leading east and north ";
            Random rnd = new Random();
            int randomnum = rnd.Next(0, 3);
            bool keeplooping = true;


            do
            {

                Console.Clear();
                Encounters.Pick(roomdesc, randomnum);
                Console.WriteLine($"\n Type command");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "north":
                        room3();
                        keeplooping = false;
                        break;
                    case "east":
                        room9();
                        keeplooping = false;
                        break;
                    case "south":
                        room1();
                        keeplooping = false;
                        break;
                    case "west":
                        Console.WriteLine($"You look at the cold damp wall and know you can't go that direction \n slightly cracked at parts ");
                        Console.WriteLine("Press enter to continue...");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Invaild in put Type help if can't remeber commands");
                        Console.ReadLine();
                        break;
                }
            } while (keeplooping == true);
        }
        static public void room3()
        {
            string roomdesc = $"";
            Random rnd = new Random();
            int randomnum = rnd.Next(0, 3);
            bool keeplooping = true;


            do
            {

                Console.Clear();
                Encounters.Pick(roomdesc, randomnum);
                Console.WriteLine($"\n Type command");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "north":

                        break;
                    case "east":

                        break;
                    case "south":

                        break;
                    case "west":

                        break;
                    default:
                        Console.WriteLine("Invaild in put Type help if can't remeber commands");
                        Console.ReadLine();
                        break;
                }
            } while (keeplooping == true);
        }
        static public void room9()
        {
            string roomdesc = $"";
            Random rnd = new Random();
            int randomnum = rnd.Next(0, 3);
            bool keeplooping = true;


            do
            {

                Console.Clear();
                Encounters.Pick(roomdesc, randomnum);
                Console.WriteLine($"\n Type command");
                string input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "north":

                        break;
                    case "east":

                        break;
                    case "south":

                        break;
                    case "west":

                        break;
                    default:
                        Console.WriteLine("Invaild in put Type help if can't remeber commands");
                        Console.ReadLine();
                        break;
                }
            } while (keeplooping == true);
        }
    }

}

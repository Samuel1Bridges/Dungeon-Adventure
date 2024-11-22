using System;

namespace Adventure
{
    public class Encounters
    {

        public static void Pick(string roomdesc, int encountNum)
        {
            if (Player.encounterchance == 100)
            {
                switch (encountNum)
                {
                    case 0:
                        goblins(roomdesc);
                        Player.encounterchancedecress(0);
                        
                        break;
                    case 1:
                        skeleton(roomdesc);
                        Player.encounterchancedecress(0);

                        break;
                    case 2:
                        zombie(roomdesc);
                        Player.encounterchancedecress(0);

                        break;
                }
            }
            else {
                Player.encounterchanceincress(5);
                Console.WriteLine(roomdesc);
            }



        }

       
        public static void goblins(string roomdesc)
        {
            Console.WriteLine( roomdesc + "There are 2 small green creatures that almost look like hideous children, " +
                              "but you know by their grunts and growls that they are not human. " +
                              "They carry medium-sized wooden clubs.");
        }

        public static void skeleton(string roomdesc)
        {
            Console.WriteLine( roomdesc + "There is a pale white figure made up of a human skeleton standing in the " +
                              "middle of the room holding an old, chipped, and rusted iron sword. " +
                              "It makes clicking sounds as it turns to see you.");
        }


        public static void zombie(string roomdesc)
        {
            Console.WriteLine( roomdesc + "There is a man standing in the middle of the room with decaying skin, " +
                              "pale white eyes, and ragged clothes, making growling sounds.");
        }
    }
}

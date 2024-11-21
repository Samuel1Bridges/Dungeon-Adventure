using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Inventory
    {
        public static Player currentPlayer = new Player();
        
        private static string[] inventory = new string[currentPlayer.inventorySize];
        public static void addInventory(Items item)
        {
            // Check if the inventory is full
            bool isFull = true;
            for (int i = 0; i < inventory.Length; i++)
            {
                if (string.IsNullOrEmpty(inventory[i])) // Find an empty spot
                {
                    isFull = false;
                    inventory[i].Add(item);  // Add the item to the first available spot
                    break;
                }
            }

            if (isFull)
            {
                Console.WriteLine("\t\t\t\t\t\t\t Your inventory is full");
            }
            else
            {
                Console.WriteLine($"\t\t\t\t\t\t\t Item successfully added to inventory: {itemInHand}");
            }


        }
    }
}

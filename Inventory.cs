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
        public static Items[] items = Items.ItemList();

        public static string[] playerInventory = new string[currentPlayer.inventorySize];
        public static void add(string item)
        {
            // Loop through the inventory to find the first empty (null) slot
            for (int i = 0; i < playerInventory.Length; i++)
            {
                if (playerInventory[i] == null)  // If the slot is empty (null)
                {
                    playerInventory[i] = item;  // Add the item to the empty slot
                    Console.WriteLine($"Item '{item}' added to inventory.");
                    return;  // Exit the method after adding the item
                }
            }

            // If no empty slot is found
            Console.WriteLine("Inventory is full. Unable to add item.");
        }
        public static void remove(string item)
        {
            for (int i = 0; i < playerInventory.Length; i++)
            {
                if (playerInventory[i] == item) {
                    playerInventory[i].Remove(i);
                }
            }
        }
        public static void craft()
        {
            Console.WriteLine("What do you wish to craft?");
            string crafting = Console.ReadLine().ToLower();
            bool foundfirstitem = false;
            bool foundlastitem = false;
            switch (crafting)
            {
                case "basic torch":
                    for (int i = 0; i < playerInventory.Length; i++)
                    {
                        if ("stick" == playerInventory[i])
                        {
                            remove(playerInventory[i]);
                            foundfirstitem = true;
                        }
                        else if ("cloth" == playerInventory[i])
                        {
                            remove(playerInventory[i]);
                            foundlastitem = true;
                        }
                    }
                    if(foundfirstitem == true && foundlastitem == true)
                    {
                        add(items[8].Name);
                        Console.WriteLine("Item successfully crafted");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("You are missing an item to craft this...");
                        Console.ReadLine();
                    }
                    break;
                case "basic pickaxe":
                    break;
            }
            
        }

        public static void get()
        {
            Console.WriteLine("Your Inventory:");

            // Loop through the inventory array
            for (int i = 0; i < playerInventory.Length; i++)
            {
                // Check if the current slot is not null or empty
                if (!string.IsNullOrEmpty(playerInventory[i]))
                {
                    // If the slot has a valid item, print it
                    Console.WriteLine(playerInventory[i]);
                }
            }

            Console.ReadLine();
        }
    }
}

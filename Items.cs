using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adventure
{
    class Items
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public string Effect { get; set; }
        public bool Damaged { get; set; }
        public int Damage { get; set; }
        public int AmourHealth { get; set; }
        public Items(string name, int value, string type, string description, string effect, int damage, bool damaged, int amourHealth)
        {
            Name = name;
            Value = value;
            Type = type;
            Description = description;
            Effect = effect;
            Damage = damage;
            Damaged = damaged;
            AmourHealth = amourHealth;
        }

        public static Items[] ItemList()
        {
            // Create an array of Items and populate it
            Items[] items = new Items[11];

            items[0] = new Items("Stick", 15, "raw material", "Stick, a piece of wood", "N/a", 0, false, 0);
            items[1] = new Items("Basic Wooden Sword", 16, "weapon", "Wooden sword, often used for training", "N/a", 5, false, 0);
            items[2] = new Items("Basic Leather Armor Chestplate", 22, "armor", "Basic adventure armor", "N/a", 0, false, 8);
            items[3] = new Items("Basic Leather Armor Hands", 20, "armor", "Basic adventure armor", "N/a", 0, false, 4);
            items[4] = new Items("Basic Leather Armor Legs", 21, "armor", "Basic adventure armor", "N/a", 0, false, 5);
            items[5] = new Items("Basic Leather Armor Boots", 20, "armor", "Basic adventure armor", "N/a", 0, false, 5);
            items[6] = new Items("Basic Leather Armor Hood", 20, "armor", "Basic adventure armor", "N/a", 0, false, 4);

            // Return the populated array of items
            return items;
        }

    }
}

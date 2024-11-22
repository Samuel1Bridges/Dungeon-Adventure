using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace Adventure
{
	class Program
	{
		public static Player currentPlayer = new Player();
		public static Inventory inventory = new Inventory();
        public static Items items;
		static void Main(string[] args)
		{
			
			string title = @"
			 _______   __    __  .__   __.   _______  _______   ______   .__   __. 
			|       \ |  |  |  | |  \ |  |  /  _____||   ____| /  __  \  |  \ |  | 
			|  .--.  ||  |  |  | |   \|  | |  |  __  |  |__   |  |  |  | |   \|  | 
			|  |  |  ||  |  |  | |  . `  | |  | |_ | |   __|  |  |  |  | |  . `  | 
			|  '--'  ||  `--'  | |  |\   | |  |__| | |  |____ |  `--'  | |  |\   | 
			|_______/  \______/  |__| \__|  \______| |_______| \______/  |__| \__| 
                                                                       
			";

			int userPick;

			Console.WriteLine(title);
			Console.WriteLine($"\t\t\t\t\t\t\tOptions");
			Console.WriteLine($"\t\t\t\t\t\t\t1. Start New Game");
			Console.WriteLine($"\t\t\t\t\t\t\t2. Load");
			Console.WriteLine($"\t\t\t\t\t\t\t3. Settings");
			Console.WriteLine($"\t\t\t\t\t\t\t4. Credits");
			Console.WriteLine($"\t\t\t\t\t\t\t5. Exit");
			Console.WriteLine("");
			
			userPick = Int32.Parse(Console.ReadLine());

			switch (userPick) {
				case 1:
					StartNew();
				break;
				case 2:
					LoadGame();
				break;
				case 3:
					Settings();
				break;
				case 4:
					Credits();
				break;
				case 5:
					System.Environment.Exit(1);
				break;
			}
		}

		static void StartNew()
		{
            Items[] items = Items.ItemList();

            Console.Clear();
			Console.WriteLine($"\t\t\t\t\t\t\tDunegon Adventure");
			Console.WriteLine($"\t\t\t\t\t\t\tWhat is your name");
			currentPlayer.name = Console.ReadLine();

			if (currentPlayer.name == "")
			{
				Console.WriteLine($"\t\t\t You have woken up in a cold and wet cave you can hear water dripping from the roof and");
				Console.WriteLine($"\t\t\t it is dark and you have forgotten everything even your name...");
			}
			else
			{
				Console.WriteLine($"\t\t\t You have woken up in a cold and wet cave you can hear water dripping from");
				Console.WriteLine($"\t\t\t the roof and it is dark and the only thing you can remember is your name " + currentPlayer.name);
			}

			Console.Clear();

			Console.WriteLine($"\t\t\t As you start to find your bearings you start to look around you you can see peice ");
			Console.WriteLine($"\t\t\t of wood on the north side of the room as you contimue to look around you can see a");
            Console.WriteLine($"\t\t\t cloth on the south side of the room");
			if(currentPlayer.hints == true)
			{
				Console.WriteLine($"\t\t\t\t\t\t\t Hint: Type Pickup and then Item in this case Cloth or stick");
			}
			string input = Console.ReadLine();
			if (input == "Pickup Cloth")
			{
	

            }
        }
		static void LoadGame()
		{
			Console.WriteLine("Load Game");
			Floor1.room1();
		}
		static void Settings()
		{
			Console.WriteLine("Settings");
		}
		static void Credits()
		{
			Console.WriteLine("Settings");
		}


	} 
}


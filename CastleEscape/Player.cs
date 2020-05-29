using System;
using System.Collections.Generic;

namespace CastleEscape
{
    class Player
    {
        //Player always starts to the South of the room.
        public char PlayerLocation = 'S';
        public bool IsPlaying = false;
        List<string> inventory = new List<string>();
        
        public Player()
        {
            IsPlaying = true;
            inventory.Add("Compass");
            //CheckPlayerLocation();
            while (IsPlaying)
            {
                PlayerCommand();
            }
        }

        public void CheckPlayerLocation()
        {
            if (PlayerLocation == 'S')
            {
                Console.WriteLine($"You are South");
            }
            else if (PlayerLocation == 'N')
            {
                Console.WriteLine($"You are North");
            }
            else if (PlayerLocation == 'E')
            {
                Console.WriteLine($"You are East");
            }
            else if (PlayerLocation == 'W')
            {
                Console.WriteLine($"You are West");
            }
        }

        public void PlayerCommand()
        {
            string input = Console.ReadLine();
            string playerCommand = input.ToUpper();
            if (playerCommand == "SOUTH" || playerCommand == "S")
            {
                PlayerLocation = 'S';
                CheckPlayerLocation();
            }
            else if (playerCommand == "NORTH" || playerCommand == "N")
            {
                PlayerLocation = 'N';
                CheckPlayerLocation();
            }
            else if (playerCommand == "EAST" || playerCommand == "E")
            {
                PlayerLocation = 'E';
                if (!CheckInventory("KEY")) {
                    inventory.Add("KEY");
                }
                CheckPlayerLocation();
            }
            else if (playerCommand == "WEST" || playerCommand == "W")
            {
                PlayerLocation = 'W';
                CheckPlayerLocation();
            }
            else if (playerCommand == "EXIT")
            {
                IsPlaying = false;
            }
            else if (playerCommand == "INVENTORY" || playerCommand == "INV")
            {
                Console.WriteLine("Your bag contains:");
                  inventory.ForEach(Console.WriteLine);
            }
        }

        public bool CheckInventory(string itemName)
        {
            return inventory.Contains(itemName);
        }


    }
}
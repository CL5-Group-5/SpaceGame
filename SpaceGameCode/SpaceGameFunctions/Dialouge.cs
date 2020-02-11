using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGameFunctions
{
    public class Dialogue
    {
        public string intro()
        {
            string intro = "Welcome to Space Salvation! You are an alien from the species Garthar on your home-planet, " +
            "Doom, located in the Medusa\nMerger. Your planet’s atmosphere is slowly deteriorating and becoming" +
            " uninhabitable for you and your species. You have\nbeen tasked by the Master Garthar to sell and " +
            "barter your planet’s goods to buy a ship manufactured by the Apocalite\nSpace Corporation on the planet " +
            "Apocalypsis, to be able to transport your species into a new galaxy. You will be able\nto choose " +
            "1 out of 3 ships (Choose wisely, each ship has different stats). You will begin with (TBD) amount of fuel " +
            "and\n$(TBD) in space currency.";
            return intro;
        }

        public string characterName()
        {
            string check;
            string name;
            Console.Write("\nPlease enter your Garthar's name: ");
            name = Console.ReadLine();
            Console.Write($"Are you sure you want to keep this name?: {name}\nEnter Yes or No: ");
            check = Console.ReadLine();
            while (check != " ")
            {
                if (check.ToLower() == "yes")
                {
                    Console.WriteLine($"Hello, {name}. Prepare for an adventure!");
                    break;
                }
                else if (check.ToLower() == "no")
                {
                    Console.Write("Okay, please enter your correct name: ");
                    name = Console.ReadLine();
                    Console.Write($"Are you sure you want to keep this name?: {name}\nEnter Yes or No: ");
                    check = Console.ReadLine();
                }
                else
                {
                    Console.Write("You have not entered yes or no, please try again: ");
                    check = Console.ReadLine();
                }
            }
            return name;
        }

        public string shipName()
        {
            string check;
            string shipName;
            Console.Write("\nPlease enter your Ship's name: ");
            shipName = Console.ReadLine();
            Console.Write($"Are you sure you want to keep this ship name?: {shipName}\nEnter Yes or No: ");
            check = Console.ReadLine();
            while (check != " ")
            {
                if (check.ToLower() == "yes")
                {
                    Console.WriteLine($"Your ship has been named {shipName}!\n");
                    break;
                }
                else if (check.ToLower() == "no")
                {
                    Console.Write("Okay, please enter your correct name: ");
                    shipName = Console.ReadLine();
                    Console.Write($"Are you sure you want to keep this name?: {shipName}\nEnter Yes or No: ");
                    check = Console.ReadLine();
                }
                else
                {
                    Console.Write("You have not entered yes or no, please try again: ");
                    check = Console.ReadLine();
                }
            }
            return shipName;
        }

        public void beginnerShip()
        {
            Console.Write("Its time to choose your ship for your adventure!\n");
            Console.WriteLine("1. Know for its fuel tank and lack of storage space, this ship comes from the Decanter" +
            "District on your home planet. It was used to travel far distances to trade immaculate jewels to other planets."
            + "If you choose this ship you will be able to travel the galaxy and have to worry about stopping as " +
            "much for fuel but the drawback is that can not hold that much cargo.\nFuel Space: 7500 Gallons Storage Space: 000\n");

            Console.Write("1. Know for its fuel tank and lack of storage space, this ship comes from the Decanter" +
            "District on your home planet. It was used to travel far distances to trade immaculate jewels to other planets."
            + "If you choose this ship you will be able to travel the galaxy and have to worry about stopping as " +
            "much for fuel but thee drawback is that can not hold that much cargo.\nFuel Space: 7500 Gallons Storage Space: 000\n");
        }


    }



     public class SpaceShips
     {
        public int storage;
        public int fuel;
        public SpaceShips(int x)
        {
            if (x == 1)
            {
                storage = 0;
                fuel = 7500;
            }
            else if (x == 2)
            {
                storage = 0;
                fuel = 6000;
            }
            else if (x == 3)
            {
                storage = 0;
                fuel = 5000;
            }
            else if (x == 4)
            {
                storage = 0;
                fuel = 7500;
            }
            else if (x == 5)
            {
                storage = 0;
                fuel = 7500;
            }
            else if (x == 6)
            {
                storage = 0;
                fuel = 7500;
            }
        }




     }
}

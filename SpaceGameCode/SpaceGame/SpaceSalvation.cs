using System;
using SpaceGameFunctions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    class SpaceSalvation
    {
        static void Main()
        {

            Item item2 = new Item();
            item2.name = "Water";
            item2.price = 25;
            item2.sellsFor = 50;
            item2.weight = 1.5;

            Item item3 = new Item();
            item3.name = "Iron";
            item3.price = 30;
            item3.sellsFor = 76;
            item3.weight = 2;

            Item item4 = new Item();
            item4.name = "Titanium";
            item4.price = 45;
            item4.sellsFor = 200;
            item4.weight = 2.5;

            Item item5 = new Item();
            item5.name = "Corn";
            item5.price = 60;
            item5.sellsFor = 258;
            item5.weight = 3;

            Item item6 = new Item();
            item6.name = "Space beans";
            item6.price = 67;
            item6.sellsFor = 234;
            item6.weight = 3.5;

            Item item7 = new Item();
            item7.name = "Space Goo";
            item7.price = 75;
            item7.sellsFor = 180;
            item7.weight = 2.5;

            Item item8 = new Item();
            item8.name = "Space Rocks";
            item8.price = 87;
            item8.sellsFor = 321;
            item8.weight = 4;

            Item item9 = new Item();
            item9.name = "Garthar Toes";
            item9.price = 117;
            item9.sellsFor = 583;
            item9.weight = 4;

            Item item10 = new Item();
            item10.name = "Garthar Teeth";
            item10.price = 152;
            item10.sellsFor = 862;
            item10.weight = 5;

            Item item11 = new Item();
            item11.name = "Alien Chicken";
            item11.price = 128;
            item11.sellsFor = 612;
            item11.weight = 4.5;

            Item item12 = new Item();
            item12.name = "Moon Dust";
            item12.price = 315;
            item12.sellsFor = 960;
            item2.weight = 6;
            Dialogue dialogue = new Dialogue();
            SpaceShips firstShip = new SpaceShips();
            string name, shipName;
            Console.WriteLine(dialogue.intro());
            name = dialogue.characterName();
            shipName = dialogue.shipName();
            Console.Clear();
            dialogue.beginnerShip();
            Console.Write("Please enter the number of the ship that you want: ");
            firstShip.chooseFirstShip();
            int fuel = firstShip.fuel;
            int storage = firstShip.storage;
            int money = 0;
            int switchCase = 1;
            Console.Clear();



            Console.WriteLine("Welcome to Garthar, your home planet! Please use the number-oriented menu to begin your adventure!");
            while(switchCase == 1)
            {
                Console.WriteLine($"Fuel: {fuel}\nStorage: {storage}\nMoney: {money}");
                Garthar garthar = new Garthar();
                garthar.planetMenu();
                switchCase++;
            switch (switchCase)
                {





                }






            }

        }
    }
}

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
            int maxFuel = firstShip.fuel;
            int storage = firstShip.storage;
            int maxStorage = firstShip.storage;
            double money = 10000;
            int gameMaster = 0;
            int nextLocation;
            int[] inventory = { 0, 0, 0, 0, 0, 0 }; //This is how the invetory works: index 0 = wheat, 1=space beans, 2 = space goo, 3=alien chicken,4=space rocks, 5=titanium

            Console.Clear();


            while(gameMaster != 1)
            {
                Garthar garthar = new Garthar(money, storage, fuel, maxStorage, maxFuel, inventory);
                garthar.planetMenu();
                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = garthar;
                Eduthear eduthear = new Eduthear(money, storage, fuel, maxStorage, maxFuel, inventory);
                eduthear.planetMenu();
                (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = eduthear;
                if (nextLocation == 0)
                {
                    Garthar garthar2 = new Garthar(money, storage, fuel, maxStorage, maxFuel, inventory);
                    (money, storage, fuel, maxStorage, maxFuel, inventory, nextLocation) = garthar2;
                }
                else 
                {
                    
                }







                gameMaster++;
            }

        }
    }
}

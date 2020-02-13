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
        }
    }
}

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
            string name, shipName;
            Console.WriteLine(dialogue.intro());
            name = dialogue.characterName();
            shipName = dialogue.shipName();
            dialogue.beginnerShip();

        }
    }
}

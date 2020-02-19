using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetClass
{
    enum Planet { Garthar = 1, Eduthear, Hochienus, Naeter, Gisamia, Apocolypsis}
    class Program
    {
        static void Main(string[] args)
        {
            Planet Garthar = Planet.Garthar;
            Console.WriteLine(Garthar);

            Planet Eduthear = Planet.Eduthear;
            Console.WriteLine(Eduthear);

            Planet Hochienus = Planet.Hochienus;
            Console.WriteLine(Hochienus);

            Planet Naeter = Planet.Naeter;
            Console.WriteLine(Naeter);

            Planet Gisamia = Planet.Gisamia;
            Console.WriteLine(Gisamia);

            Planet Apocolypsis = Planet.Apocolypsis;
            Console.WriteLine(Apocolypsis);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            World newWorld = new World(30);
            Multiverse multiverse = new Multiverse();
            Rules rules = new Rules();

            Console.WriteLine("Select an option");
            Console.WriteLine("1 - Block");
            Console.WriteLine("2 - Honeycomb");
            Console.WriteLine("3 - Three Cell Oscilator");
            Console.WriteLine("4 - Toad");
            Console.WriteLine("5 - Random");

            int x = int.Parse(Console.ReadLine());
            string keyMessage = "Press a key to start your game";




        }
    }
}

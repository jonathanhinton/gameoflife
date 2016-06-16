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

            bool goBack = true;

            World newWorld = new World(30);
            Multiverse multiverse = new Multiverse();
            Rules rules = new Rules();

            Console.WriteLine("Select an option");
            Console.WriteLine("1 - Block");
            Console.WriteLine("2 - Honeycomb");
            Console.WriteLine("3 - Three Cell Oscilator");
            Console.WriteLine("4 - Toad");
            Console.WriteLine("5 - Random");
            Console.WriteLine("q - return to this menu");



            int x = int.Parse(Console.ReadLine());
            string keyMessage = "Press a key to start your game";

            switch (x)
            {
                case 1:
                    World blockWorld = multiverse.block(newWorld);
                    rules.DrawWorld(blockWorld);
                    Console.WriteLine(keyMessage);
                    Console.ReadKey();
                    rules.InitialSetup(blockWorld);
                    Console.ReadKey();
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        goBack = false;
                    }
                    break;

                case 2:
                    World honeyCombWorld = multiverse.honeyComb(newWorld);
                    rules.DrawWorld(honeyCombWorld);
                    Console.WriteLine(keyMessage);
                    Console.ReadKey();
                    rules.InitialSetup(honeyCombWorld);
                    break;

                case 3:
                    World threeCellOscillatorWorld = multiverse.threeCellOscillator(newWorld);
                    rules.DrawWorld(threeCellOscillatorWorld);
                    Console.WriteLine(keyMessage);
                    Console.ReadKey();
                    rules.InitialSetup(threeCellOscillatorWorld);
                    break;

                case 4:
                    World toadWorld = multiverse.Toad(newWorld);
                    rules.DrawWorld(toadWorld);
                    Console.WriteLine(keyMessage);
                    Console.ReadKey();
                    rules.InitialSetup(toadWorld);
                    break;

                case 5:
                    World randomWorld = multiverse.Random(newWorld);
                    rules.DrawWorld(randomWorld);
                    Console.WriteLine(keyMessage);
                    Console.ReadKey();
                    rules.InitialSetup(randomWorld);
                    break;

                default:
                    World randomDefault = multiverse.Random(newWorld);
                    rules.DrawWorld(randomDefault);
                    Console.WriteLine(keyMessage);
                    Console.ReadKey();
                    rules.InitialSetup(randomDefault);
                    break;
            }

            

        }
    }
}

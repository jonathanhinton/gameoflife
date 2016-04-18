using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class Rules
    {
        public int days { get; set; }
        public bool zeroDay { get; set; }

        public Rules()
        {
            days = 0;
            zeroDay = true;
        }

        public void InitialSetup(World newWorld)
        {
            zeroDay = false;
            for (int row = 0; row < newWorld.spaces.GetLength(0); row++)
            {
                for (int col = 0; col < newWorld.spaces.GetLength(1); col++)
                {
                    int neighbors = neighborCounter(row, col, newWorld);
                    PopulatePotentialWorld(row, col, neighbors, newWorld);
                }
            }
            newWorld.spaces = (int[,])newWorld.potentialSpaces.Clone();
            Array.Clear(newWorld.potentialSpaces, 0, newWorld.potentialSpaces.Length);
            DrawWorld(newWorld);
        }

        public int neighborCounter(int row, int col, World world)
        {
            //set up counter to count neighbors
            int counter = 0;

            //setup bools to check neighbooring spaces
            bool top = false;
            bool right = false;
            bool bottom = false;
            bool left = false;

            //check for cells on the boundary of 2d array
            if (row == 0) { top = true; }
            if (col == 0) { left = true; }
            if (row == Math.Sqrt(world.spaces.Length)-1) { bottom = true; }
            if (col == Math.Sqrt(world.spaces.Length)-1) { right = true; }
            
            if (!top)
            {
                if (world.spaces[row - 1, col] == 1)
                {
                    counter++;
                }
            }

            if (!top || !right)
            {
                if (world.spaces[row - 1, col + 1] == 1)
                {
                    counter++;
                }
            }

            if (!right)
                if (world.spaces[row, col + 1] == 1)
                {
                    counter++;
                }

            if (!right || !bottom)
            {
                if (world.spaces[row + 1, col + 1] == 1)
                {
                    counter++;
                }
            }

            if (!bottom)
            {
                if (world.spaces[row + 1, col] == 1)
                {
                    counter++;
                }
            }

            if (!bottom || !left)
            {
                if (world.spaces[row + 1, col - 1] == 1)
                {
                    counter++;
                }
            }

            if (!left)
            {
                if (world.spaces[row, col - 1] == 1)
                {
                    counter++;
                }
            }

            return counter;
        }

        public void PopulatePotentialWorld(int row, int col, int neighbors, World world)
        {
            if (world.spaces[row, col] == 1)
            {
                if (neighbors < 2)
                {
                    world.potentialSpaces[row, col] = 0;
                }

                if (neighbors == 2 || neighbors == 3)
                {
                    world.potentialSpaces[row, col] = 1;
                }

                if (neighbors > 3)
                {
                    world.potentialSpaces[row, col] = 0;
                }
            }
            else
            {
                if (neighbors == 3)
                {
                    world.potentialSpaces[row, col] = 1;
                }
            }
        }

        public void DrawWorld(World world)
        {
            Console.Clear();
            StringBuilder consoleWorld = new StringBuilder();

            if (!zeroDay)
            {
                days++;
            }

            consoleWorld.Append("Days" + days + "\r\n");

            for (int row = 0; row < world.spaces.GetLength(0); row++)
            {
                for (int col = 0; col < world.spaces.GetLength(1); col++)
                {
                    if (world.spaces[row, col] == 1)
                    {
                        consoleWorld.Append("@");
                    }
                    else
                    {
                        consoleWorld.Append(" ");
                    }
                }

                consoleWorld.Append("\r\n");
            }

            Console.WriteLine(consoleWorld);

            System.Threading.Thread.Sleep(500);
        }
    }
}

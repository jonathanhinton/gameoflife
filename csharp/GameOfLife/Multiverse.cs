using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Multiverse
    {
        public World block(World currentWorld)
        {
            int row = 3;
            int col = 3;
            currentWorld.spaces[row, col] = 1;
            currentWorld.spaces[row, col+1] = 1;
            currentWorld.spaces[row+1, col] = 1;
            currentWorld.spaces[row+1, col+1] = 1;

            return currentWorld;
        }

        public World honeycomb(World currentWorld)
        {
            int row = 5;
            int col = 5;
            currentWorld.spaces[row, col] = 1;
            currentWorld.spaces[row-1, col + 1] = 1;
            currentWorld.spaces[row, col + 3] = 1;
            currentWorld.spaces[row + 1, col + 2] = 1;
            currentWorld.spaces[row + 1, col + 1] = 1;

            return currentWorld;
        }

        public World threeCellOscilator(World currentWorld)
        {
            int row = 3;
            int col = 3;
            currentWorld.spaces[row, col] = 1;
            currentWorld.spaces[row - 1, col] = 1;
            currentWorld.spaces[row + 1, col + 3] = 1;

            return currentWorld;
        }

        public World Toad(World currentWorld)
        {
            int row = 5;
            int col = 5;
            currentWorld.spaces[row, col] = 1;
            currentWorld.spaces[row, col+1] = 1;
            currentWorld.spaces[row, col+2] = 1;
            currentWorld.spaces[row+1, col-1] = 1;
            currentWorld.spaces[row+1, col] = 1;
            currentWorld.spaces[row+1, col+1] = 1;

            return currentWorld;

        }

        public World Random(World currentWorld)
        {
            Random random = new System.Random();
            for (int row = 0; row < currentWorld.spaces.GetLength(0); row++)
            {
                for (int col = 0; col < currentWorld.spaces.GetLength(1); col++)
                {
                    int randomNumber = (int)Math.Round(random.NextDouble());

                    if (randomNumber == 1)
                    {
                        currentWorld.spaces[row, col] = 1;
                    }
                    else
                    {
                        currentWorld.spaces[row, col] = 0;
                    }
                }
            }

            return currentWorld;
        }
    }
}

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
            int col = 3;
            int row = 3;
            currentWorld.spaces[col, row] = 1;
            currentWorld.spaces[col, row+1] = 1;
            currentWorld.spaces[col+1, row] = 1;
            currentWorld.spaces[col+1, row+1] = 1;

            return currentWorld;
        }

        public World honeycomb(World currentWorld)
        {
            int col = 5;
            int row = 5;
            currentWorld.spaces[col, row] = 1;
            currentWorld.spaces[col-1, row + 1] = 1;
            currentWorld.spaces[col, row + 3] = 1;
            currentWorld.spaces[col + 1, row + 2] = 1;
            currentWorld.spaces[col + 1, row + 1] = 1;

            return currentWorld;
        }
    }
}

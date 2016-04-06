using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    public class World
    {
        public int[,] spaces{ get; set; }

        public World(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException();
            }
            spaces = new int[size, size];
        }
    }
}

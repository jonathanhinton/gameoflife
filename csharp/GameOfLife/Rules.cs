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
            //code that implements the rules and the world goes here
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
            if(row == 0) { top = true; }
            if(col == 0) { left = true; }
            if(row == Math.Sqrt(world.spaces.Length)-1) { bottom = true; }
            if(col == Math.Sqrt(world.spaces.Length)-1) { right = true; }


            return counter;
        }
    }
}

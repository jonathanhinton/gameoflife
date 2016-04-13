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

    }
}

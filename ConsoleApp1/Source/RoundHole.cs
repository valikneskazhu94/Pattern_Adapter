using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source
{
    public class RoundHole
    {
        private int radius;
        public RoundHole(int radius)
        {
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
        public bool Fits(iRoundPeg peg)
        {
            if (peg.getRadius() <= radius)
                return true;
            else
                return false;
        }

      
    }
}

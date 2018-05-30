using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Source
{
    public class RoundPeg:iRoundPeg
    {
        private int radius;
        public RoundPeg(int radius)
        {
            this.radius = radius;
        }
        public int getRadius()
        {
            return radius;
        }
        
    }
}

using ConsoleApp1.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Adapter
{
    public class SquarePegAdapter:iRoundPeg
    {
        private SquarePeg peg = null;
        public SquarePegAdapter(SquarePeg peg)
        {
            this.peg = peg;
        }
        public int getRadius()
        {
            int halfWidth = peg.getWidth() / 2;
            int result=Convert.ToInt32(Math.Sqrt(Math.Pow((halfWidth), 2) * 2));
            return result;
        }
    }
}

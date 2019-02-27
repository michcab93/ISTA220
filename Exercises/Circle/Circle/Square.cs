using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Square
    {
        private int side;

        public Square (int s)
        {
           this.side = s;
        }

        public double Area(int s)
        {
            return (Math.Pow(s, 2));
        }

        public int Perimeter(int s)
        {
            return (s * 4);
        }
    }
}

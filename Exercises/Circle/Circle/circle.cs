using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class circle
    {
        private int radius;
        
        public circle(int r)     // this is a contructor? or a field?
        {
            this.radius = r;      //this is a place holder for the object which you will name later 
        }

        public double Area(int radius)      //this is a method 
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public double Circum(int radius)      //this is a method
        {
            return (2 * Math.PI * radius);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an interger as radius:");
            string strrad = Console.ReadLine();
            int intrad = Int32.Parse(strrad);

            circle circle = new circle(intrad);
            double area = circle.Area(intrad);
            Console.WriteLine($"The area is {area}");

            double circum = circle.Circum(intrad);
            Console.WriteLine($"The circumfrance is {circum}");


            Console.WriteLine("Enter an interger as side:");
            string strside = Console.ReadLine();
            int intside = Int32.Parse(strside);

            //circle Square = new circle(intrad);
            Square s = new Square(3);
            area = s.Area(intside);
            Console.WriteLine($"The area is {area}");

            double p = s.Perimeter(intside);
            Console.WriteLine($"The circumfrance is {p}");

        }
    }
}

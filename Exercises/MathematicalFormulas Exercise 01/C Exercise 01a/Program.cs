using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercise_01a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart_1,_circumference_and_area_of_a_circle.");
            Console.Write("Enter_an_interger_for_the_radius;_");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);
            double dblradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * dblradius;
            Console.WriteLine($"The_circumference_is_{circumference}");
            double areaC = Math.PI * Math.Pow(dblradius, 2.0);
            Console.WriteLine($"The_area_is_{areaC}");


            Console.WriteLine("\nPart_2_volume_of_a_hemisphere");
            Console.Write("Enter_an_interger_for_the_radius;_");
            string strradiusA = Console.ReadLine();
            double dblradiusA = int.Parse(strradiusA);
            double volume = ((4.0 / 3.0) * Math.PI * Math.Pow(dblradiusA, 3.0)) / 2.0;
            Console.WriteLine($"The_volume_is_{volume}");

            Console.WriteLine("\nPart_3_Area_of_triangle.");
            Console.Write("Enter_lenght_of_side_a;_");
            string strsidea = Console.ReadLine();
            double dblsidea = int.Parse(strsidea);
            Console.Write("Enter_lenght_of_side_b;_");
            string strsideb = Console.ReadLine();
            double dblsideb = int.Parse(strsideb);
            Console.Write("Enter_lenght_of_side_c;_");
            string strsidec = Console.ReadLine();
            double dblsidec = int.Parse(strsidec);
            double dblp = (dblsidea + dblsideb + dblsidec)/2 ;
            Console.Write($"P_is_equal_to_{dblp}");
            double areaT = Math.Sqrt(dblp * (dblp - dblsidea) * (dblp - dblsideb) * (dblp - dblsidec));
            Console.WriteLine($"The_area_is_{areaT}");

            Console.WriteLine("\nPart_4_Solving_a_quadratic_equation.");
            Console.WriteLine("Solving_for_quadatric_equation_ax^2+bx+c=0");
            Console.Write("Enter_value_of_a;_");
            string strvaluea = Console.ReadLine();
            double dblvaluea = int.Parse(strvaluea);
            Console.Write("Enter_value_of_b;_");
            string strvalueb = Console.ReadLine();
            double dblvalueb = int.Parse(strvalueb);
            Console.Write("Enter_value_of_c;_");
            string strvaluec = Console.ReadLine();
            double dblvaluec = int.Parse(strvaluec);
            double dbladdsolution = (-dblvalueb + Math.Sqrt(Math.Pow(dblvalueb,2) - 4 * dblvaluea * dblvaluec)) / (2 * dblvaluea);
            double dblsubsolution = (-dblvalueb - Math.Sqrt(Math.Pow(dblvalueb, 2) - 4 * dblvaluea * dblvaluec)) / (2 * dblvaluea);
            Console.Write($"The_solution_is_{dbladdsolution},{dblsubsolution}");
        } 
    }
}

   

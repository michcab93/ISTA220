using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercise03a
{
    class Program
    {
        static void Main(string[] args)
        {
            optionmenue();
        }

        private static void optionmenue()
        {
            Console.WriteLine("1,_circumference_and_area_of_a_circle.");

            Console.WriteLine("2,_volume_of_a_hemisphere");

            Console.WriteLine("3,_Area_of_triangle.");

            Console.WriteLine("4,_Solving_a_quadratic_equation.");

            Console.WriteLine("5,_Exit_Program");

            Console.WriteLine("Enter program to run:");

            int part = Convert.ToInt32(Console.ReadLine());


            if (part == 1)

            {

                circumference_and_area_of_a_circle();

            }



            else if (part == 2)

            {

                volume_of_a_hemisphere();

            }



            else if (part == 3)

            {

                Area_of_triangle();

            }



            else if (part == 4)

            {

                Solving_a_quadratic_equation();

            }

            else if (part == 5)
            {
                Console.WriteLine("Good Bye");
            }


            else

            {

                Console.WriteLine("Entry not available.");
                optionmenue();
            }
        }

        private static void Solving_a_quadratic_equation()
        {
            Console.WriteLine("\nPart_4_Solving_a_quadratic_equation.");
            Console.WriteLine("Solving_for_quadatric_equation_ax^2+bx+c=0");
            Console.Write("Enter_value_of_a;_");
            string strvaluea = Console.ReadLine();
            double dblvaluea = int.Parse(strvaluea);
            try
            {
                if (dblvaluea <= 0)
                {
                    Console.WriteLine("value must be greater than 0.");
                    Solving_a_quadratic_equation();
                }

                else if (dblvaluea > 0)

                {
                    Console.WriteLine("");
                }
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            Console.Write("Enter_value_of_b;_");
            string strvalueb = Console.ReadLine();
            double dblvalueb = int.Parse(strvalueb);
            if (dblvalueb <= 0)
            {
                Console.WriteLine("value must be greater than 0.");
                Solving_a_quadratic_equation();
            }

            else if (dblvalueb > 0)

            {
                Console.WriteLine("");
            }
            Console.Write("Enter_value_of_c;_");
            string strvaluec = Console.ReadLine();
            double dblvaluec = int.Parse(strvaluec);
            if (dblvaluec <= 0)
            {
                Console.WriteLine("value must be greater than 0.");
                Solving_a_quadratic_equation();
            }

            else if (dblvaluec > 0)

            {
                Console.WriteLine("");
            }
            double dbladdsolution = (-dblvalueb + Math.Sqrt(Math.Pow(dblvalueb, 2) - 4 * dblvaluea * dblvaluec)) / (2 * dblvaluea);
            double dblsubsolution = (-dblvalueb - Math.Sqrt(Math.Pow(dblvalueb, 2) - 4 * dblvaluea * dblvaluec)) / (2 * dblvaluea);
            Console.Write($"The_solution_is_{dbladdsolution},{dblsubsolution}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            optionmenue();
        }

        private static void Area_of_triangle()
        {
            Console.WriteLine("\nPart_3_Area_of_triangle.");
            Console.Write("Enter_lenght_of_side_a;_");
            string strsidea = Console.ReadLine();
            double dblsidea = int.Parse(strsidea);
            try
            {
                if (dblsidea <= 0)
                {
                    Console.WriteLine("side must be greater than 0.");
                    Area_of_triangle();
                }

                else if (dblsidea > 0)

                {
                    Console.WriteLine("");
                }
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            Console.Write("Enter_lenght_of_side_b;_");
            string strsideb = Console.ReadLine();
            double dblsideb = int.Parse(strsideb);
            try
            {
                if (dblsideb <= 0)
                {
                    Console.WriteLine("side must be greater than 0.");
                    Area_of_triangle();
                }

                else if (dblsideb > 0)

                {
                    Console.WriteLine("");
                }
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            Console.Write("Enter_lenght_of_side_c;_");
            string strsidec = Console.ReadLine();
            double dblsidec = int.Parse(strsidec);
            try
            {
                if (dblsidec <= 0)
                {
                    Console.WriteLine("side must be greater than 0.");
                    Area_of_triangle();
                }

                else if (dblsidec > 0)

                {
                    Console.WriteLine("");
                }
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
            double dblp = (dblsidea + dblsideb + dblsidec) / 2;         
            double areaT = Math.Sqrt(dblp * (dblp - dblsidea) * (dblp - dblsideb) * (dblp - dblsidec));
            Console.WriteLine($"The_area_is_{areaT}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            optionmenue();
        }

        private static void volume_of_a_hemisphere()
        {
            Console.WriteLine("\nPart_2_volume_of_a_hemisphere");
            Console.Write("Enter_an_interger_for_the_radius;_");
            string strradiusA = Console.ReadLine();
            double dblradiusA = int.Parse(strradiusA);
            try
            {
                if (dblradiusA <= 0)
                {
                    Console.WriteLine("radius must have a radius greater than 0.");
                    volume_of_a_hemisphere();
                }

                else if (dblradiusA > 0)

                {
                    Console.WriteLine("valid entry");
                }
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
            }
           
            double volume = ((4.0 / 3.0) * Math.PI * Math.Pow(dblradiusA, 3.0)) / 2.0;
            Console.WriteLine($"The_volume_is_{volume}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            optionmenue();
        }

        private static void circumference_and_area_of_a_circle()
        {
            Console.Write("Enter_an_interger_for_the_radius;_");
            string strradius = Console.ReadLine();
            int intradius = int.Parse(strradius);

            try
            {
                if (intradius <= 0)
                {
                    Console.WriteLine("radius must have a radius greater than 0.");
                    Console.WriteLine("enter valid number");
                    circumference_and_area_of_a_circle();
                } 
    
                else if (intradius > 0)

                {
                    Console.WriteLine("valid entry");
                }
            }

            catch (FormatException f)
            {
                Console.WriteLine(f.Message);
                circumference_and_area_of_a_circle();
            }

            double dblradius = int.Parse(strradius);
            double circumference = 2 * Math.PI * dblradius;
            Console.WriteLine($"The_circumference_is_{circumference}");
            double areaC = Math.PI * Math.Pow(dblradius, 2.0);
            Console.WriteLine($"The_area_is_{areaC}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            optionmenue();
        }
    }
}

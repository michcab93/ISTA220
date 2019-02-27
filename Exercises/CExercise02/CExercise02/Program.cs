using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CExercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Grade,__");
            string numGrade = Console.ReadLine();
            double dnumGrade = double.Parse(numGrade);


            if (dnumGrade >= 90)

            {
                Console.WriteLine("A");
            }
            else if (dnumGrade >= 80)
            {
                Console.WriteLine("B");
            }
            else if (dnumGrade >= 70)
            {
                Console.WriteLine("C");
            }
            else if (dnumGrade >= 60)
            {
                Console.WriteLine("D");
            }
            else if (dnumGrade <= 59)
            {
                Console.WriteLine("F");
            }
        
            
        }
    }
}
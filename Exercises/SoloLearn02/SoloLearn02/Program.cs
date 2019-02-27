using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoloLearn02
{
    class Program
    {
        static void Main(string[] args)
        {
                     //if statement exercise 
            Console.WriteLine("Comparing two numbers using IF statements.");
            Console.WriteLine("Enter first number a = _");
            string valuea = Console.ReadLine();
            int a = int.Parse(valuea);
            Console.WriteLine("Enter second number b = _");
            string valueb = Console.ReadLine();
            int b = int.Parse(valueb);

            if (a == b)
            {
                Console.WriteLine("numbers are equal");
            }
            else if  (a > b)
            {
                Console.WriteLine("a is greater than b");
            }
            else if (a < b)
            {
                Console.WriteLine("a is less than b");
            }



            Console.WriteLine("Will you marry me?");
            Console.WriteLine("Type 1 for Yes \n Type 2 for Maybe, \n Type 3 for NO");
            int answer = int.Parse(Console.ReadLine());

            if (answer < 3)
            {
                Console.WriteLine("HELL YES");
                if (answer == 2)
                {
                    Console.WriteLine("WE can take our time");
                }
            }
            else
            {
                Console.WriteLine("It was just a joke =)");
            }
        }
    }
}

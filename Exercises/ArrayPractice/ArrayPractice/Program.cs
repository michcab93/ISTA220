using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            numbers[0] = 11;
            numbers[1] = 22;
            numbers[2] = 33;
            numbers[3] = 44;
            numbers[4] = 55;


            int len = numbers.Length;
            Console.WriteLine($"variable len has the value {len}");

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine($"element {i} is nuber {numbers[i]}.");
                Console.WriteLine("");

                Console.WriteLine($"element {i % 2} is number {numbers[i % 2]}.");
                Console.WriteLine("");

                Console.WriteLine($"element {i} is number {numbers[(i + 2) % 5]}.");
                Console.WriteLine("");

                Console.WriteLine($"element {i} is number {numbers[4 - i]}.");
                Console.WriteLine("");

            }

            Console.WriteLine("this is the array backwards");
            for (int i = --len; 1 >= 0; i--)

            {
                Console.WriteLine($"element {i} is nuber {numbers[i]}.");
            }

        
            Console.WriteLine("this is the foreach loop");

            foreach  (int e in numbers)
            {
                Console.WriteLine($"element {e}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExcercise05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ArrayA = { 0, 2, 3, 4, 6, 8, 10 };

            int[] ArrayB = { 1, 3, 5, 7, 9 };

            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };


            int sumA = sum(ArrayA);

            int sumB = sum(ArrayB);

            int sumC = sum(ArrayC);


            Console.WriteLine($"The mean of Array A is {mean(ArrayA, sumA)}");

            Console.WriteLine($"The mean of Array B is {mean(ArrayB, sumB)}");

            Console.WriteLine($"The mean of Array C is {mean(ArrayC, sumC)}");



            Console.WriteLine("The reverse of Array A is:");

            reverse(ArrayA);



            Console.WriteLine("The reverse of Array B is:");

            reverse(ArrayB);



            Console.WriteLine("The reverse of Array C is:");

            reverse(ArrayC);

        }

        private static int sum(int[] arr)

        {

            int sum = 0;

            foreach (int v in arr)

            {

                sum += v;

            }

            return sum;
        }

        private static double mean(int[] arr, int sum)

        {

             double mean = (double)sum / arr.Length;

             return mean;

        }


        private static void reverse(int[] arr)

        {

            for (int i = arr.Length - 1; i >= 0; i--)

            {

                Console.Write($" {arr[i]}");

            }

            Console.WriteLine("");

        }

        private static void rotate(string direction, int places, int[] arr)
        {
            int len = arr.Length;
            if (direction == "R")
                places = len - places;
            for (int i = 0; i < len; i++)
                Console.WriteLine($"{arr[(i + places) % len]}");
        }

        private static void sort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}

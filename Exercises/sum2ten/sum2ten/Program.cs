using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum2ten
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 10;
            int sum = 0;
            get_sum(start, end, sum);
        }

        private static void get_sum(int start, int end, int sum)
        {
            Console.WriteLine($"get_sum({start},_{end},_{sum})");
            start = start + 1;
            sum = sum + start;
            if (start < end)
            {
                get_sum(start, end, sum);
            }
            else
            {
                Console.WriteLine($"The_sum_is_{sum}");
            }
        }
    }
}

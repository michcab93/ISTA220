using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            short notop = ~204;
            Console.WriteLine($"not operator is {notop}");

            short lsop = 204 << 1;
            Console.WriteLine($"left shift is {lsop}");

            short rsop = 204 >> 1;
            Console.WriteLine($"right shift is {rsop}");

            short orop = 204 | 24;
            Console.WriteLine($"orop is {orop}");

            short andop = 204 & 24;
            Console.WriteLine($"andop is {andop}");

            short xorop = 204 ^ 24;
            Console.WriteLine($"xorop is {xorop}");
        }
    }
}

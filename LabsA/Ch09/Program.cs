#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            Month first = Month.December;
            Console.WriteLine(first);

            Month second = Month.January;
            Console.WriteLine(second);
            first++;
            second++;
            Console.WriteLine(first);
            Console.WriteLine(second);
            first++;
            Console.WriteLine(first);
            second++;
            Console.WriteLine(second);
            Console.WriteLine();

            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2015, Month.November, 13);
            Console.WriteLine(weddingAnniversary);

            Date copy = weddingAnniversary;
            Console.WriteLine(copy);

            weddingAnniversary.AdvanceMonth();
            Console.WriteLine($"1. {weddingAnniversary}");
            Console.WriteLine($"2. {copy}");

           // Date weddingAnniversaryCopy = weddingAnniversary;
           //Console.WriteLine($"Value of copy is {weddingAnniversaryCopy}");

            //weddingAnniversary.AdvanceMonth();
            //Console.WriteLine($"New value of weddingAnniversary is {weddingAnniversary}");
            //Console.WriteLine($"Value of copy is still {weddingAnniversaryCopy}");


        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

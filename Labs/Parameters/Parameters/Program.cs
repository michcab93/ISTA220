#region using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace Parameters
{
    class Program
    {
        static void doWork()
        {
            int i = 0;
            Console.WriteLine(i);
            Pass.Value(i);
            Console.WriteLine(i);
            i = Pass.ValueA(1);
            Console.WriteLine(1);
            Console.WriteLine();

            WrappedInt wi = new WrappedInt();
            Console.WriteLine(wi.Number);
            Pass.Reference(wi);
            Console.WriteLine(wi.Number);
            Console.WriteLine($"Number2 is {wi.Number2}");
            Console.WriteLine($"Number3 is {wi.Number3}");


            Console.WriteLine();

            int j = 13;
            Console.WriteLine(j);
            Pass.Gertrude(ref j);
            Console.WriteLine(j);
          
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            {
            Console.WriteLine("this is function dWork");
        }

        static void Main(string[] args)
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

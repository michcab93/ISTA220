using System;

namespace Parameters
{
    class Pass
    {
        public static void Value(int param)
        {
            param = 42;
            Console.WriteLine($"           In value method param is {param}");
        }

        public static int ValueA(int param)
        {
            Console.WriteLine($"         In ValueaA, param is{param}");
            return (42 + param);

        }
        
        public static void Gertrude (ref int param)
        {
            param = 42;
        }

        public static void Reference(WrappedInt param)
        {
            param.Number = 42;
        }
    }
}

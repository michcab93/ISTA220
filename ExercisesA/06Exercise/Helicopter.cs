using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Helicopter : Vehicle

    {

        public void TakeOff()

        {

            Console.WriteLine("Taking off");

        }



        public void Land()

        {

            Console.WriteLine("Landing");

        }



        public override void Drive()

        {

            Console.WriteLine("Taxiing");

        }



        public void ascend()

        {

            Console.WriteLine("Ascending");

        }



        public void descend()

        {

            Console.WriteLine("Descending");

        }

    }
}

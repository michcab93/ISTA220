using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Soldiers
    {
        public virtual void loadVehicle()

        {

            Console.WriteLine("Mount Up!!");

        }



        public virtual void receiveFire()

        {

            Console.WriteLine("Contact!!!");

        }



        public virtual void returnFire()

        {

            Console.WriteLine("PEW! PEW! PEW!");

        }



        public virtual void dismount()

        {

            Console.WriteLine("Dismounting");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Weaponds
    {
        public void fire(string soundfiring)

        {

            Console.WriteLine(soundfiring);

        }



        public virtual void reload()

        {

            Console.WriteLine("Reloading");

        }



        public virtual void aim()

        {

            Console.WriteLine("Aiming");

        }



        public virtual void load()

        {

            Console.WriteLine("Loading");

        }
    }
}

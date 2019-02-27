using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2
{
    public class Cow
    {
        public Cow()
        {

        }

        public string name;
        public string type;

        public Cow(string n, string t)
        {
            this.name = n;
            this.type = t;
        }


        public string Talk(string t)
        {
            return ($"says {t}");
        }

        public string Do(string d)
        {
            return ($"likes to {d}");
        }

        public string Eat(string f)
        {
            return ($"likes to eat {f}");
        }
    }

}

/* int age = 20;

string name = "Josh"

cow(age, name)
{
    cowage = age;
    cowname = name;
}
    Console.WriteLine(${ cow.cowname})

    Console.WriteLine(cow.cowname.tostring());*/


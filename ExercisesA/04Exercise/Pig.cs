using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2
{
    public class Pig
    {
        public Pig()
        {

        }

        public string name;
        public string type;

        public Pig(string n, string t)
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

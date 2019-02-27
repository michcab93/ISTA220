using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2
{
    public class Rabit
    {
        public Rabit()
        {

        }

        string name;
        string type;

        public Rabit(string n, string t)
        {
            this.name = n;
            this.type = t;
        }

        public string love(string l)
        {
            return ($"Really loves {l}");
        }

        public string want(string w)
        {
            return ($"wants {w}");
        }

        public string dwells(string d)
        {
            return ($"lives in {d}");
        }
    }
}

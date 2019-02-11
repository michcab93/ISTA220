using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm2
{
    public class Chicken
    {
        public Chicken()
        {

        }

        public string name;
        public string type;

        public Chicken(string n, string t)
        {
            this.name = n;
            this.type = t;
        }

        public string reproduce(string e)
        {

            return ($"has offspring by {e}");
        }

        public string feel(string f)
        {
            return ($"feels {f}");
        }

        public string sing(string song)
        {
            return ($"sing {song}");
        }

    }
}

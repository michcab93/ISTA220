using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Cow
    {
        private string name;

        public Cow()
        {
        }

        public Cow(string name)
        {
             this.name = "sally"; 
        }

        public string Who(string name)
        {
            return name;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class Song
    {
        public string Name;
        public double Length;
        public override string ToString()
        {
            return Name + " " + Length;
        }
    }
}

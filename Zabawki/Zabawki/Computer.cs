using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Computer
    {
        private static int count = 0;

        public Computer()
        {
            count++;
        }

        public override string ToString()
        {
            return "Computer " + count;
        }
    }
}

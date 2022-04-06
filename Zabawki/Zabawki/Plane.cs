using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Plane : IAccelerate, IRise
    {
        private int speed;
        private int rise;
        private static int count = 0;
        private string name;

        public Plane(int speed, int rise)
        {
            Speed = speed;
            Rise = rise;
            count++;
            name = "Plane " + count;
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 0 && value < 2000)
                    speed = value;
                else if (value <= 0)
                    speed = 0;
                else
                    speed = 2000;
            }
        }

        public int Rise
        {
            get { return rise; }
            set
            {
                if (value > 0 && value < 1000)
                    rise = value;
                else if (value <= 0)
                    rise = 0;
                else
                    rise = 1000;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}

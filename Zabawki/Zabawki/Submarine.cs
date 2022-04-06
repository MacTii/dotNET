using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    public interface IDive
    {
        int Depth { get; set; }
    }

    class Submarine : IAccelerate, IDive
    {
        private int speed;
        private static int count = 0;
        private int depth;
        private string name;

        public Submarine(int speed, int depth)
        {
            Speed = speed;
            Depth = depth;
            count++;
            name = "Submarine " + count;
        }

        public int Depth
        {
            get { return depth; }
            set
            {
                if (value > 0 && value > 100)
                    depth = value;
                else if (value <= 0)
                    depth = 0;
                else
                    depth = 100;
            }
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 0 && value < 100)
                    speed = value;
                else if (value <= 0)
                    speed = 0;
                else
                    speed = 100;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}

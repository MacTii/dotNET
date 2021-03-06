using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zabawki
{
    class Car : IAccelerate
    {
        private int speed;
        private static int count = 0;
        private string name;

        public Car(int speed)
        {
            Speed = speed;
            count++;
            name = "Car " + count;
        }

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > -50 && value < 220)
                    speed = value;
                else if (value <= -50)
                    speed = -50;
                else
                    speed = 220;
            }
        }

        public override string ToString()
        {
            return name;
        }
    }
}

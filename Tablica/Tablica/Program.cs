using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica
{
    static class Constants
    {
        public const int Size = 10;
    }

    class Program
    {
        private int[] table = new int[Constants.Size];

        static void Main(string[] args)
        {
        }

        public int this[int index]
        {
            get
            {
                return table[index];
            }
            set
            {
                table[index] = value;
            }
        }

        public void Add()
        {

        }
    }
}

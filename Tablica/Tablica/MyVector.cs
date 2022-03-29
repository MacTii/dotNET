using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica
{
    class MyVector
    {
        private int[] myVector;

        public int Capacity { get; private set; } // array capacity 

        public int Size { get; private set; } // number of elements in the array

        public MyVector(int N) // N = number of elements
        {
            myVector = new int[N];
        }

        public int this[int index] // an indexer of type int     
        {
            get
            {
                return myVector[index];
            }
            set
            {
                myVector[index] = value;
            }
        }

        public void Add(int value)
        {

        }
    }
}

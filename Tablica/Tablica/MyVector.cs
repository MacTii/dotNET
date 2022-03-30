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

        public MyVector(int N) // N = number of elements | allocate N elements to vector
        {
            myVector = new int[N];
            Capacity = N;
            Size = 0;
        }

        public int this[int index] // an indexer of type int     
        {
            get
            {
                if (index < 0 || index >= Capacity)
                    throw new IndexOutOfRangeException("Index was out of range"); // throwing an exception when index < 0

                return myVector[index];
            }
            set
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Index was out of range"); // throwing an exception when index < 0

                else if (index >= Capacity)
                    Allocate(index + 1);

                myVector[index] = value;
            }
        }

        public void ShowVector() // show elements in vector
        {
            Console.WriteLine(string.Format("Vector: ({0}).", string.Join(", ", myVector)));
        }

        public void ShowCapacity() // show capacity of vector
        {
            Console.WriteLine("Capacity = " + Capacity);
        }

        public void ShowSize() // show size of vector
        {
            Console.WriteLine("Size = " + Size);
        }

        public void Add(int value)
        {
            if(Size >= Capacity) // if size>=capacity allocate 2*N memory of elements
            {
                Allocate(2 * Capacity);
            }

            myVector[Size] = value;
            Size++;
        }

        private void Allocate(int N)
        {
            if (N < 0)
                throw new IndexOutOfRangeException("Index was out of range");

            int[] myNewVector = new int[N];
            Array.Copy(myVector, myNewVector, Size);

            Capacity = N;
            myVector = myNewVector;
        }
    }
}

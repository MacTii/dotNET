using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    class MyVector
    {
        // declare delegate
        public delegate void MyVectorHandlerSize(int vectorSize);
        public delegate void MyVectorHandlerAllocate(int vectorLength);

        // declare event
        public event MyVectorHandlerSize MyVectorEventLogSize;
        public event MyVectorHandlerAllocate MyVectorEventLogAllocate;

        // method handling event
        protected virtual void OnSizeChanged(int size)
        {
            MyVectorEventLogSize?.Invoke(size);
        }

        protected virtual void OnAllocateChanged(int length)
        {
            MyVectorEventLogAllocate?.Invoke(length);
        }

        private int[] myVector;

        public int Size { get; private set; } // number of elements in the array

        public MyVector(int N) // N = number of elements | allocate N elements to vector
        {
            myVector = new int[N];
            Size = 0;
        }

        public int this[int index] // an indexer of type int     
        {
            get
            {
                if (index < 0 || index >= Size)
                    throw new IndexOutOfRangeException("Index was out of range"); // throwing an exception when index < 0

                return myVector[index];
            }
            set
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Index was out of range"); // throwing an exception when index < 0

                if (index >= myVector.Length)
                {
                    Allocate(2 * (index + 1));
                    OnAllocateChanged(myVector.Length);
                }

                if (index >= Size)
                {
                    Size = index + 1;
                    OnSizeChanged(Size);
                }

                myVector[index] = value;
            }
        }

        public void ShowVector() // show elements in vector
        {
            Console.WriteLine(string.Format("Vector: ({0}).", string.Join(", ", myVector)));
        }

        public void ShowLength() // show capacity of vector
        {
            Console.WriteLine("Length of memory allocated = " + myVector.Length);
        }

        public void ShowAllocate(int length)
        {
            Console.WriteLine("Event: Memory allocated to length = " + length);
        }

        public void ShowSize(int size) // show size of vector
        {
            Console.WriteLine("Event: Vector size changed to = " + size);
        }

        public void Add(int value)
        {
            this[Size] = value;
        }

        private void Allocate(int N)
        {
            if (N < 0)
                throw new IndexOutOfRangeException("Index was out of range");

            Array.Resize(ref myVector, N);
        }
    }
}

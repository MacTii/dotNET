using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    class Events
    {
        // declare delegate
        public delegate void MyVectorHandler(int vectorSize);

        // declare event
        public event MyVectorHandler MyVectorEventLog;

        // method handling event
        public void OnSizeChanged(int size)
        {
            MyVectorEventLog?.Invoke(size);
        }
    }

    class MyVector
    {
        private int[] myVector;

        public int Size { get; private set; } // number of elements in the array

        Events eventVector;

        public MyVector(int N) // N = number of elements | allocate N elements to vector
        {
            myVector = new int[N];
            Size = 0;
            eventVector = new Events();
            eventVector.MyVectorEventLog += ShowSize;
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
                    Allocate(2 * (index + 1));

                if (index >= Size)
                {
                    Size = index + 1;
                    eventVector.OnSizeChanged(Size);
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

        public void ShowSize(int size) // show size of vector
        {
            Console.WriteLine("Event: Changed size vector to = " + size);
        }

        public void Add(int value)
        {
            this[Size++] = value;
            eventVector.OnSizeChanged(Size);
        }

        private void Allocate(int N)
        {
            if (N < 0)
                throw new IndexOutOfRangeException("Index was out of range");

            Array.Resize(ref myVector, N);
        }
    }
}

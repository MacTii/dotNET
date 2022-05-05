using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zdarzenia
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector vector = new MyVector(5);
            vector.MyVectorEventLogSize += vector.ShowSize;
            vector.MyVectorEventLogAllocate += vector.ShowAllocate;

            vector.Add(3);
            vector.Add(15);
            vector.Add(65);
            vector.Add(32);
            vector.Add(6);

            // check size, capacity and elements in vector 
            vector.ShowVector();
            vector.ShowLength();
            //vector.ShowSize();

            vector.Add(15);
            vector.ShowVector();
            vector.ShowLength();
            //vector.ShowSize();

            // checking how works indexer
            vector[5] = 69;

            vector.ShowVector();
            vector.ShowLength();
            //vector.ShowSize();

            // adding more elements to check if the allocation was successful
            vector.Add(5);

            // check elements in vector again
            vector.ShowVector();

            // testing vector operations
            vector.Add(7);
            vector.Add(7);
            vector.Add(7);
            vector.Add(7);
            vector.ShowLength();

            // showing vector's operations
            vector.ShowVector();
            vector.ShowLength();
            //vector.ShowSize();

            // checking the operation of the indexer
            vector[vector.Size] = 69;

            vector.ShowVector();
            vector.ShowLength();
            //vector.ShowSize();

            vector[20] = 69;

            vector.ShowVector();
            vector.ShowLength();
            //vector.ShowSize();

            try
            {
                Console.WriteLine(vector[56]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

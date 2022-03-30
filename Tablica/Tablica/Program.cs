using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablica
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector vector = new MyVector(5);

            vector.Add(3);
            vector.Add(15);
            vector.Add(65);
            vector.Add(32);
            vector.Add(6);

            // check size, capacity and elements in vector 
            vector.ShowVector();
            vector.ShowCapacity();
            vector.ShowSize();

            // checking how works indexer
            vector[5] = 69;

            vector.ShowVector();
            vector.ShowCapacity();
            vector.ShowSize();

            // adding more elements to check if the allocation was successful
            vector.Add(5);

            // check elements in vector again
            vector.ShowVector();

            // testing vector operations
            vector.Add(7);
            vector.Add(7);
            vector.Add(7);
            vector.Add(7);
            vector.ShowCapacity();

            // showing vector's operations
            vector.ShowVector();
            vector.ShowCapacity();

            // checking the operation of the indexer
            vector[vector.Capacity] = 69;

            vector.ShowVector();
            vector.ShowCapacity();

            vector[20] = 69;

            vector.ShowVector();
            vector.ShowCapacity();
        }
    }
}

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
}

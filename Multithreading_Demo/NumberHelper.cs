using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_Demo
{
    internal class NumberHelper
    {
        private int _num;

        public NumberHelper(int num)
        {
            _num = num;
        }

        public void TypeSafeThreadFn()
        {
            Console.WriteLine($"Data passed to thread fn executed in type safe manner with value {_num}");
        }
    }
}

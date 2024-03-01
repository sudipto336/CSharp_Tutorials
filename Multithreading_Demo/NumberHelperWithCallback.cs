using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading_Demo
{

    public delegate void CallbackDelegate(int num);

    internal class NumberHelperWithCallback
    {
        private int _num;
        private CallbackDelegate _callbackDelegate;

        public NumberHelperWithCallback(int num, CallbackDelegate callbackDelegate)
        {
            _num = num;
            _callbackDelegate = callbackDelegate;
        }

        public void TypeSafeThreadFn()
        {
            Console.WriteLine($"Data passed to thread fn executed in type safe manner with value {_num}");

            if (_callbackDelegate != null)
            {
                _callbackDelegate(_num);
            }
        }
    }
}

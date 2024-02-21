using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{


    internal class EventPublisherWithCustomDelegate
    {
        public delegate void Notify();

        public event Notify ProcessCompleted;

        public void StartProcess ()
        {
            Console.WriteLine("Process with event with custom delegate started...");
            RaiseProcessCompleted();
        }

        protected virtual void RaiseProcessCompleted()
        {
            Console.WriteLine("Process completed and event with custom delegate raised...");
            ProcessCompleted?.Invoke();
        }
    }
}

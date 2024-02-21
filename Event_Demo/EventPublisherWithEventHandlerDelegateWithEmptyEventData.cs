using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{


    internal class EventPublisherWithEventHandlerDelegateWithEmptyEventData
    {

        public event EventHandler ProcessCompleted;

        public void StartProcess ()
        {
            Console.WriteLine("Process with EventHandler delegate with empty event data started...");
            RaiseProcessCompleted(EventArgs.Empty);
        }

        protected virtual void RaiseProcessCompleted(EventArgs e)
        {
            Console.WriteLine("Process completed event with EventHandler delegate with empty event data raised...");
            ProcessCompleted?.Invoke(this, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{


    internal class EventPublisherWithEventHandlerDelegateWithBoolEventData
    {

        public event EventHandler<bool> ProcessCompleted;

        public void StartProcess ()
        {
            try
            {
                Console.WriteLine("Process with event with EventHandler delegate with bool event data started...");
                RaiseProcessCompleted(true);
            } catch (Exception ex)
            {
                RaiseProcessCompleted(false);
            }
        }

        protected virtual void RaiseProcessCompleted(bool IsSuccessful)
        {
            Console.WriteLine(IsSuccessful ? "Process completed successfully and event with EventHandler delegate with bool event data raised..." : "Process failed and event with EventHandler delegate with bool event data raised...");
            ProcessCompleted?.Invoke(this, IsSuccessful);
        }
    }
}

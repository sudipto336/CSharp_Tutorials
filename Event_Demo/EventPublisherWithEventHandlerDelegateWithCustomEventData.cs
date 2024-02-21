using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{
    internal class EventPublisherWithEventHandlerDelegateWithCustomEventData
    {

        public event EventHandler<ProcessEventArgs> ProcessCompleted;

        public void StartProcess ()
        {
            var data = new ProcessEventArgs();
            try
            {
                Console.WriteLine("Process with event with EventHandler delegate with custom event data started...");
                data.IsScuccessful = true;
                data.CompletionTime = DateTime.Now;
                RaiseProcessCompleted(data);
            } catch (Exception ex)
            {
                data.IsScuccessful = false;
                data.CompletionTime = DateTime.Now;
                RaiseProcessCompleted(data);
            }
        }

        protected virtual void RaiseProcessCompleted(ProcessEventArgs args)
        {
            Console.WriteLine(args.IsScuccessful ? "Process completed successfully and event with EventHandler delegate with custom event data raised...": "Process failed and event with EventHandler delegate with custom event data raised...");
            ProcessCompleted?.Invoke(this, args);
        }
    }
}


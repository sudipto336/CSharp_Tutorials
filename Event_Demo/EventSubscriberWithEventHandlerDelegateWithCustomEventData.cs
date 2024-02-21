using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{
    internal class EventSubscriberWithEventHandlerDelegateWithCustomEventData
    {
        public static void RaiseAndSubscribeEvent()
        {
            EventPublisherWithEventHandlerDelegateWithCustomEventData eventPublisher = new EventPublisherWithEventHandlerDelegateWithCustomEventData();
            eventPublisher.ProcessCompleted += HandleProcessCompleted;
            eventPublisher.StartProcess();
        }

        private static void HandleProcessCompleted(object sender, ProcessEventArgs processEventArgs)
        {
            Console.WriteLine(processEventArgs.IsScuccessful ? "Process completed successfully and event with event handler delegate with bool event data handled..." : "Process failed and event with event handler delegate with bool event data handled...");
            Console.WriteLine($"Process completion/failure time: {processEventArgs.CompletionTime}");
        }
    }
}

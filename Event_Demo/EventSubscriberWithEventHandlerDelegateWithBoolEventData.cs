using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{
    internal class EventSubscriberWithEventHandlerDelegateWithBoolEventData
    {
        public static void RaiseAndSubscribeEvent()
        {
            EventPublisherWithEventHandlerDelegateWithBoolEventData eventPublisher = new EventPublisherWithEventHandlerDelegateWithBoolEventData();
            eventPublisher.ProcessCompleted += HandleProcessCompleted;
            eventPublisher.StartProcess();
        }

        private static void HandleProcessCompleted(object sender, bool IsCompleted)
        {
            Console.WriteLine(IsCompleted ? "Process completed successfully and event with event handler delegate with bool event data handled..." : "Process failed and event with event handler delegate with bool event data handled...");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{


    internal class EventSubscriberWithEventHandlerDelegateWithEmptyEventData
    {
        public static void RaiseAndSubscribeEvent()
        {
            EventPublisherWithEventHandlerDelegateWithEmptyEventData eventPublisher = new EventPublisherWithEventHandlerDelegateWithEmptyEventData();
            eventPublisher.ProcessCompleted += HandleProcessCompleted;
            eventPublisher.StartProcess();
        }

        private static void HandleProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("Process completed successfully and event with event handler delegate with empty event data handled...");
        }
    }
}

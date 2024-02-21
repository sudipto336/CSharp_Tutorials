using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Demo
{


    internal class EventSubscriberWithCustomDelegate
    {
        public static void RaiseAndSubscribeEvent()
        {
            EventPublisherWithCustomDelegate eventPublisher = new EventPublisherWithCustomDelegate();
            eventPublisher.ProcessCompleted += HandleProcessCompleted;
            eventPublisher.StartProcess();
        }

        private static void HandleProcessCompleted()
        {
            Console.WriteLine("Process completed successfully and event with custom delegate handled...");
        }
    }
}

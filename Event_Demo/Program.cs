namespace Event_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EventSubscriberWithCustomDelegate.RaiseAndSubscribeEvent();
            Console.WriteLine("***************************************");
            EventSubscriberWithEventHandlerDelegateWithBoolEventData.RaiseAndSubscribeEvent();
            Console.WriteLine("***************************************");
            EventSubscriberWithEventHandlerDelegateWithCustomEventData.RaiseAndSubscribeEvent();
        }
    }
}

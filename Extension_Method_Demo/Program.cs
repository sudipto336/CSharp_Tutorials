namespace Extension_Method_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int caller = 10;
            int param = 20;

            bool isCallerGreatherThanParam = caller.IsGreaterThan(param);

            Console.WriteLine($"Is extension method caller ({caller}) greater than param ({param})? - {isCallerGreatherThanParam}");
        }
    }
}

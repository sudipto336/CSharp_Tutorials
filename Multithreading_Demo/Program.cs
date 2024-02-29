namespace Multithreading_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(BasicThreadFn);
            thread.Start();
        }

        static void BasicThreadFn() { Console.WriteLine("Thread fn executed"); }
    }
}

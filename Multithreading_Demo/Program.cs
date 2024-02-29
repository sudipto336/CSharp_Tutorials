namespace Multithreading_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(BasicThreadFn);

            //Or

            ThreadStart threadStart = new ThreadStart(BasicThreadFn2);

            Thread thread2 = new Thread(threadStart);

            thread1.Start();

            thread2.Start();
        }

        static void BasicThreadFn() { Console.WriteLine("Thread fn executed"); }

        static void BasicThreadFn2() { Console.WriteLine("Thread2 fn executed"); }

        static void BasicParameterizedThreadFn(Object num) { Console.WriteLine("Thread2 fn executed"); }
    }
}

namespace Multithreading_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Thread method with no param

            //Creating thread instance 

            //1st way

            Thread thread1 = new Thread(BasicThreadFn);

            //2nd way

            ThreadStart threadStart = new ThreadStart(BasicThreadFn2);

            Thread thread2 = new Thread(threadStart);

            
            
            //Thread method with param

            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(BasicParameterizedThreadFn);

            Thread thread3 = new Thread(parameterizedThreadStart);

            
            
            //starting thread execution - making thread state as Running

            thread1.Start();

            thread2.Start();

            thread3.Start(5);
        }

        static void BasicThreadFn() { Console.WriteLine("Thread fn executed"); }

        static void BasicThreadFn2() { Console.WriteLine("Thread2 fn executed"); }

        static void BasicParameterizedThreadFn(Object num) { 
            int param = Convert.ToInt32(num);
            Console.WriteLine($"Thread23 fn executed with param {param}");
        }
    }
}

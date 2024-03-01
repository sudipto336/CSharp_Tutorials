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

            
            
            //Thread method with param (not type safe)

            ParameterizedThreadStart parameterizedThreadStart = new ParameterizedThreadStart(NotTypeSafeParameterizedThreadFn);

            Thread thread3 = new Thread(parameterizedThreadStart);

            //Passing data to thread fn in type safe manner

            NumberHelper numberHelper = new NumberHelper(6);

            ThreadStart threadStart3 = new ThreadStart(numberHelper.TypeSafeThreadFn);

            Thread thread4 = new Thread(threadStart3);

            
            
            //starting thread execution - making thread state as Running

            thread1.Start();

            thread2.Start();

            //data not passed type safely

            thread3.Start(5);

            //data passed type safely

            thread4.Start();
        }

        static void BasicThreadFn() { Console.WriteLine("Thread1 fn executed"); }

        static void BasicThreadFn2() { Console.WriteLine("Thread2 fn executed"); }

        static void NotTypeSafeParameterizedThreadFn(Object num)
        {

            //not type safe thread fn as if data of type other than int sent, then runtime execption will occur
            int param = Convert.ToInt32(num);
            Console.WriteLine($"Not type safe parameterized thread fn executed with param {param}");
        }
    }
}

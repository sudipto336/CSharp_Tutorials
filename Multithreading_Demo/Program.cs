namespace Multithreading_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main thread started");

            //Thread method with no param

            //Creating thread instance 

            //1st way

            Thread thread1 = new Thread(BasicThreadFn1);

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

            //Passing data to thread fn in type safe manner with callback

            CallbackDelegate callbackDelegate = new CallbackDelegate(BasicThreadFn3);

            NumberHelperWithCallback numberHelperWithCallback = new NumberHelperWithCallback(7, callbackDelegate);

            ThreadStart threadStart4 = new ThreadStart(numberHelperWithCallback.TypeSafeThreadFn);

            Thread thread5 = new Thread(threadStart4);



            //starting thread execution - making thread state as Running

            thread1.Start();

            thread2.Start();

            //data not passed type safely

            thread3.Start(5);

            //data passed type safely

            thread4.Start();

            //data passed type safely along with callback fn

            thread5.Start();

            Thread threadForMethod1 = new Thread(Method1);
            Thread threadForMethod2 = new Thread(Method2);
            Thread threadForMethod3 = new Thread(Method3);

            threadForMethod1.Start();
            threadForMethod2.Start();
            threadForMethod3.Start();

            threadForMethod1.Join();
            //threadForMethod2.Join();
            //threadForMethod3.Join();

            if (threadForMethod2.Join(TimeSpan.FromSeconds(3)))
            {
                Console.WriteLine("threadForMethod2 execution completed in 3 sec");
            } else
            {
                Console.WriteLine("threadForMethod2 execution not completed in 3 sec");
            }

            if (threadForMethod3.Join(3000))
            {
                Console.WriteLine("threadForMethod3 execution completed in 3 sec");
            }
            else
            {
                Console.WriteLine("threadForMethod3 execution not completed in 3 sec");
            }

            Thread threadForMethod4 = new Thread(Method4);

            threadForMethod4.Start();

            if (threadForMethod4.IsAlive)
            {
                Console.WriteLine("threadForMethod4 is still running");
            } else
            {
                Console.WriteLine("threadForMethod4 execution ended");
            }

            threadForMethod4.Join();

            if (threadForMethod4.IsAlive)
            {
                Console.WriteLine("threadForMethod4 is still running");
            }
            else
            {
                Console.WriteLine("threadForMethod4 execution ended");
            }

            Console.WriteLine("Main thread ended");

            Console.Read();
        }

        static void BasicThreadFn1() { Console.WriteLine("BasicThreadFn1 fn executed"); }

        static void BasicThreadFn2() { Console.WriteLine("BasicThreadFn2 fn executed"); }

        static void NotTypeSafeParameterizedThreadFn(Object num)
        {

            //not type safe thread fn as if data of type other than int sent, then runtime execption will occur
            int param = Convert.ToInt32(num);
            Console.WriteLine($"Not type safe parameterized thread fn executed with param {param}");
        }

        static void BasicThreadFn3(int num) { Console.WriteLine($"BasicThreadFn3 executed with param {num}"); }

        static void Method1() { 
            Console.WriteLine("Thread for Method1 started");
            Thread.Sleep(000);
            Console.WriteLine("Thread for Method1 ended");
        }

        static void Method2()
        {
            Console.WriteLine("Thread for Method2 started");
            Thread.Sleep(2000);
            Console.WriteLine("Thread for Method2 ended");
        }

        static void Method3()
        {
            Console.WriteLine("Thread for Method3 started");
            Thread.Sleep(5000);
            Console.WriteLine("Thread for Method3 ended");
        }

        static void Method4()
        {
            Console.WriteLine("Thread for Method4 started");
            Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine("Thread for Method4 ended");
        }
    }
}

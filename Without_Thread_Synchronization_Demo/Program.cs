namespace Without_Thread_Synchronization_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookMyShow bookMyShow = new BookMyShow();

            Thread thread1 = new Thread(bookMyShow.BookTicket)
            {
                Name = "thread1"
            };
            Thread thread2 = new Thread(bookMyShow.BookTicket)
            {
                Name = "thread2"
            };
            Thread thread3 = new Thread(bookMyShow.BookTicket)
            {
                Name = "thread3"
            }; ;

            Thread thread4 = new Thread(SomeMethod);
            Thread thread5 = new Thread(SomeMethod);
            Thread thread6 = new Thread(SomeMethod);

            thread1.Start();
            thread2.Start();
            thread3.Start();

            //thread4.Start();
            //thread5.Start();
            //thread6.Start();

            Console.ReadKey();
        }

        static void SomeMethod()
        {
            Console.Write("[SomeMethod stated. ");
            Thread.Sleep(1000);
            Console.WriteLine("SomeMethod ended]");
        }
    }
}

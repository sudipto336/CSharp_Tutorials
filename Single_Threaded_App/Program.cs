namespace Single_Threaded_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeMethod();
            SomeMethod();
            SomeMethod();

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

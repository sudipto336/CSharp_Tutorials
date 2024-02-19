using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
    internal static class ActionDemo
    {
        private static void Sum(int x, int y)
        {
            int sumResult = x + y;
            Console.WriteLine($"Sum result (using Action): {sumResult}");
        }

        public static void PrintActionOutput()
        {
            Action<int, int> add = Sum;

            //using anonymous method
            Action getRandomNumber = delegate ()
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 100);
                Console.WriteLine($"Random number (using Action): {randomNumber}");
            };

            //using lambda expression
            Action<int, int> getProduct = (int a, int b) =>
            {
                int productResult = a * b;
                Console.WriteLine($"Product result (using Action): {productResult}");
            };

            add(1, 2);
            getRandomNumber();
            getProduct(2, 3);
        }
    }
}

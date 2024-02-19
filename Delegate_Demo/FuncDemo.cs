using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
    internal static class FuncDemo
    {
        private delegate int UserDefinedFuncDelegate(int a, int b);

        private static string Sum(int x, int y)
        {
            return (x + y).ToString();
        }

        private static int Divide(int x, int y)
        {
            return x / y;
        }

        public static void PrintFuncOutput()
        {
            Func<int, int, string> add = Sum;

            UserDefinedFuncDelegate userDefinedFuncDelegate = Divide;

            //using anonymous method
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };

            //using lambda expression
            Func<int, int, int> getProduct = (int a, int b) => a*b;

            string sumResult = add(1, 2);
            int divisionResult = userDefinedFuncDelegate(4, 2);
            int randomNumber = getRandomNumber();
            int productResult = getProduct(2, 3);

            Console.WriteLine($"Sum result (using Func): {sumResult}");
            Console.WriteLine($"Division result (using user defined Func): {divisionResult}");
            Console.WriteLine($"Random number (using Func): {randomNumber}");
            Console.WriteLine($"Product result (using Func): {productResult}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Demo
{
    internal static class PredicateDemo
    {
        private delegate bool UserDefinedPredicateDelegate(string a);

        private static bool IsUpperCase(string str)
        {
            return str.Equals(str.ToUpper());
        }

        private static bool IsPalindromeString(string str)
        {
            string reverseString = "";
            int strLength = 0;
            foreach (char c in str)
            {
                strLength++;
            }

            for (int i = strLength - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }

            return reverseString.Equals(str);
        }

        public static void PrintPredicateOutput()
        {
            Predicate<string> isUpper = IsUpperCase;

            UserDefinedPredicateDelegate userDefinedActionDelegate = IsPalindromeString;

            //using anonymous method
            Predicate<int> isPalindrome = delegate (int x)
            {
                int originalNumber = x;
                int reverseNumber = 0;

                while (x > 0)
                {
                    int rem = x % 10;
                    reverseNumber = reverseNumber * 10 + rem;
                    x = x / 10;
                }

                return originalNumber == reverseNumber;
            };

            //using lambda expression
            Predicate<int> isAmstrong = (int a) =>
            {
                int digitCount = 0;
                int originalNumber = a;
                int numberToCheckAmstrong = 0;

                while (a > 0)
                {
                    digitCount++;
                    a = a / 10;
                }

                a = originalNumber;

                while (a > 0)
                {
                    int rem = a % 10;
                    numberToCheckAmstrong = numberToCheckAmstrong + Convert.ToInt32(Math.Pow(rem, digitCount));
                    a = a / 10;
                }

                return originalNumber == numberToCheckAmstrong;
            };

            bool isUpperCaseStr = isUpper("ABC");
            bool isPalindromeStr = userDefinedActionDelegate("ABC");
            bool isPalindromeNumber = isPalindrome(121);
            bool isAmstrongNumber = isAmstrong(153);


            Console.WriteLine($"Is upper case string (using Predicate) ? : {isUpperCaseStr}");
            Console.WriteLine($"Is palindrome string (using user defined Predicate) ? : {isPalindromeStr}");
            Console.WriteLine($"Is palindrome no. (using Predicate) ? : {isPalindromeNumber}");
            Console.WriteLine($"Is amstrong no. (using Predicate) ? : {isAmstrongNumber}");
        }
    }
}

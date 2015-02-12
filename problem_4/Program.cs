using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LargestPolindromeNumber());
            Console.WriteLine(LargestPolindromeNumber2());
            Console.ReadLine();
        }

        //Mine
        public static int LargestPolindromeNumber()
        {
            int maxPolindromic = 0;

            for (int i = 100; i <= 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    int tmpNumber = i * j;

                    string tmpNumberString = tmpNumber.ToString();

                    char[] tmpNumberToCharArray = tmpNumberString.ToCharArray();

                    Array.Reverse(tmpNumberToCharArray);
                    string numberReverseString = new String(tmpNumberToCharArray);

                    int numberReverse = 0;
                    if (int.TryParse(numberReverseString, out numberReverse))
                    {
                        if (tmpNumber == numberReverse && maxPolindromic < numberReverse)
                        {
                            maxPolindromic = numberReverse;
                        }
                    }
                }
            }

            return maxPolindromic;
        }

        public static int LargestPolindromeNumber2()
        {
            int largestPolindrome = 0;
            int a = 999;

            while (a >= 100)
            {
                int b = 999;

                while (b >= a)
                {
                    if (a * b <= largestPolindrome)
                        break;

                    if (isPalindrome(a * b))
                    {
                        largestPolindrome = a * b;
                    }

                    b = b - 1;
                }

                a = a - 1;
            }

            return largestPolindrome;
        }

        public static int ReverseNumber(int n)
        {
            int reversed = 0;

            while (n > 0)
            {
                reversed = 10 * reversed + n % 10;
                n = n / 10;
            }

            return reversed;
        }

        public static bool isPalindrome(int n)
        {
            return n == ReverseNumber(n);
        }
    }
}

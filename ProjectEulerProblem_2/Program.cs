using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Format("SUM:{0}", FibonacciTerms(4000000)));
            Console.WriteLine(String.Format("SUM:{0}", FibonacciTerms2(4000000)));
            Console.ReadLine();
        }

        private static int FibonacciTerms(int limit)
        {
            int sum = 0;
            int result = 0;
            int i = 1;
            int j = 2;

            Console.WriteLine(i);
            Console.WriteLine(j);

            result = j;

            while (sum < limit)
            {
                sum = i + j;

                Console.WriteLine(sum);

                if (sum % 2 == 0 && sum < limit)
                {
                    Console.WriteLine(String.Format("even-valued:{0}", sum));

                    result += sum;                 
                }

                i = j;
                j = sum;
            }

            return result;
        }

        private static int FibonacciTerms2(int limit)
        {
            int sum = 0;
            int i = 1;
            int j = 1;

            Console.WriteLine(i);

            while (j < limit)
            {
                Console.WriteLine(i + j);

                if (j % 2 == 0)
                {
                    Console.WriteLine(String.Format("even-valued:{0}", j));

                    sum += j;
                }

                var h = i + j;
                i = j;
                j = h;
            }

            return sum;
        }

    }
}

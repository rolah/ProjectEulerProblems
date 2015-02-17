using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_st_prim = 10001;

            int counter = 0;
            for (int i = 0; i < 1000000; i++)
            {
                if (IsPrime(i))
                {
                    counter++;

                    if (counter < number_st_prim)
                    {
                        Console.WriteLine(i);
                    }

                    if (counter == number_st_prim)
                    {
                        Console.WriteLine("{0}.: {1}", counter, i);
                        break;
                    }
                }
            }

            Console.ReadLine();
        }

        public static bool IsPrime(int number)
        {
            if ((number & 1) == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return number != 1;
        }
    }
}

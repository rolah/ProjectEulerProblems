using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MultiplesOf3and5(1000));
            Console.WriteLine(MultiplesOf3and5(10));
            Console.ReadLine();
        }

        public static int MultiplesOf3and5(int num)
        { 
            int result = 0;

            for (int i = 0; i <  num; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    result+= i;
                }                
            }

            return result;
        }
    }
}

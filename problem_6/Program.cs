using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_6
{
    class Program
    {
        static void Main(string[] args)
        {          
            int NumbersSquare_Sum = 0;
            int SumNumbers_Square = 0;

            for (int i = 1; i <= 100; i++)
            {
                NumbersSquare_Sum += i * i;
                SumNumbers_Square += i;
            }

            SumNumbers_Square = SumNumbers_Square * SumNumbers_Square;

            Console.WriteLine(SumNumbers_Square - NumbersSquare_Sum);
            Console.ReadLine();
        }
    }
}

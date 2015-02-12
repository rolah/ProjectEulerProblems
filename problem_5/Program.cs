using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 1;
            int i = 1;
            while (i < 20)
            {
                i = 1;
                while (j % i == 0 && i < 20)
                {
                    i++;
                }

                if (i == 20)
                {
                    Console.WriteLine(j);                
                }
                
                j++;
            }


            Console.ReadLine();
        }
    }
}

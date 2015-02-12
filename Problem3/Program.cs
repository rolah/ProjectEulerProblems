using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 600851475143;

            var lfact = 0;

            if (n % 2 == 0)
            {
                n = n / 2;-,zhz
                lfact = 2;

                while (n % 2 == 0)
                {
                    n = n / 2;
                }
            }
            else
            {
                lfact = 2;
            }

        }
    }
}

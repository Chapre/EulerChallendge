using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._53
{
    class CombinatoricSelections : ITestable
    {
        public void Test()
        {
            int count = 0;
            for (int n = 100; n > 0; n--)
            {
                for (int r = 0; r < n; r++)
                {
                    BigInteger result = factorial(n) / (factorial(r) * factorial(n - r));
                    if (result > 1000000)
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine($"Count --> {count}");
        }

        public static BigInteger factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            BigInteger y = x;
            for (int i = 1; i < x; i++)
            {
                y *= i;
            }
            return y;
        }
    }
}

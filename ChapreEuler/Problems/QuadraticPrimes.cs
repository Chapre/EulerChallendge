using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems
{
    class QuadraticPrimes : ITestable
    {
        public void Test()
        {
            int maxCount = 0;
            for (int i = -999; i < 1000; i++)
            {
                for (int j = -1000; j <= 1000; j++)
                {
                    int a = i;
                    int b = j;
                    int primecount = 0;
                    int indexer = 0;
                    while (true)
                    {
                        var term = indexer * indexer + a * indexer + b;
                        if (!IsPrime(Math.Abs(term)))
                            break;

                        indexer++;
                        primecount++;
                    }

                    if (primecount > maxCount)
                    {
                        maxCount = primecount;
                        Console.WriteLine($"a:{a}, b:{b} ---> prime count {primecount}");
                    }

                }
            }

            Console.WriteLine("Done");
        }

        bool IsPrime(int value)
        {
            if (value <= 1)
                return false;
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

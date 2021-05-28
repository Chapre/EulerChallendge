using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._30
{
    class DigitFifthPowers : ITestable
    {
        public void Test()
        {
            BigInteger finalsum = 0;
            for (int i = 2; i < 10000000; i++)
            {
                var source = i;
                BigInteger sum = 0;
                while (source > 0)
                {
                    var digit = source % 10;
                    source /= 10;
                    sum += BigInteger.Pow(digit, 5);
                }

                //Console.WriteLine($"{i} --> {sum}");
                if (sum==i)
                {
                    Console.WriteLine($"Digit fifth powers --> {i}");
                    finalsum += i;
                }
            }

            Console.WriteLine($"Done --> {finalsum}");
        }
    }
}

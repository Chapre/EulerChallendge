using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._51
{
    class PrimeDigitReplacements : ITestable
    {
        public void Test()
        {
            int max = 0;
            for (int i = 3; i < 100000; i = i + 2)
            {
                var sel = i % 10;
                if (sel == 5)
                    continue;
                int count = FamillyReplacePrimes(i, 1,3);
                if (max<count && count<10)
                {
                    max = count;
                    Console.WriteLine($"{i}  ---> family count:{count}");
                }
            }
        }

        private int FamillyReplacePrimes(int n, int start, int len)
        {
            int count = 0;
            for (int i = 0; i <= 9; i++)
            {
                if (QuickHelper.IsPrime(ReplaceWith(n, i, start, len)))
                    count++;
            }

            return count;
        }

        private int ReplaceWith(int n, int digit, int start, int count)
        {
            int indexer = 0;
            var num = 0;
            while (n > 0)
            {
                if (indexer >= start && indexer < start + count)
                {
                    num = num + digit * (int)Math.Pow(10, indexer);
                }
                else
                {
                    var d = n % 10;
                    num = num + d * (int)Math.Pow(10, indexer);
                    n = n / 10;
                }

                indexer++;
            }

            return num;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._23
{
    class NonAbundantSums : ITestable
    {
        public void Test()
        {
            List<int> abondants = new List<int>();
            for (int i = 0; i <= 28123; i++)
            {
                if (SumProperDivisors(i) > i)
                {
                    abondants.Add(i);
                    Console.WriteLine($"Abundant --> {i}");
                }
            }

            Console.WriteLine($"Abundant count --> {abondants.Count}");
            List<int> abondantCombines = new List<int>();
            for (int i = 0; i < abondants.Count; i++)
            {
                for (int j = 0; j < abondants.Count; j++)
                {
                    abondantCombines.Add(abondants[i] + abondants[j]);
                }
            }

            abondantCombines = abondantCombines.Distinct().ToList();
            var sum = 0;
            for (int i = 0; i < 28123; i++)
            {
                if (abondantCombines.Contains(i))
                    continue;
                sum = sum + i;
                Console.WriteLine($"Non-Abundant {i} --> sum {sum}");
            }

            Console.WriteLine($"final sum {sum}");
        }

        int SumProperDivisors(int num)
        {
            int sqrt = (int)Math.Sqrt(num);
            bool square = sqrt * sqrt == num;
            var sum = 0;
            for (int i = 1; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    if ((i == sqrt && square) || i == 1)
                        continue;
                    sum = sum + num / i;
                }
            }

            return sum;
        }
    }
}

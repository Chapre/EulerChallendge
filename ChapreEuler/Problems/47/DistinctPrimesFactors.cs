using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._47
{
    class DistinctPrimesFactors : ITestable
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            const int len = 4;
            for (int i = 1; i < 1000000; i++)
            {
                bool result = true;
                for (int j = 0; j < len || !result; j++)
                {
                    var div = QuickHelper.GetPrimeFactors(i + j, true);
                    if (div.Count != len)
                    {
                        result = false;
                        break;
                    }

                    for (int k = 0; k < div.Count; k++)
                    {
                        if (!QuickHelper.IsPrime(div[k]))
                        {
                            result = false;
                            break;
                        }
                    }
                }

                if (result)
                {
                    Console.WriteLine($"Distinct primes factors--> {i}");
                }

            }
        }

        public List<long> GetPrimeFactors(long number, bool distinct)
        {
            var primes = new List<long>();
            int sqrt = (int)Math.Sqrt(number);
            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    if (!distinct || (distinct && !primes.Contains(i)))
                        primes.Add(i);
                    if (i == sqrt)
                        continue;
                    if (!distinct || (distinct && !primes.Contains(number / i)))
                        primes.Add(number / i);
                }
            }

            return primes;
        }
    }
}

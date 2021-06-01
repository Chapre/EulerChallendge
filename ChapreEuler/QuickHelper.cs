using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler
{
    public static class QuickHelper
    {
        public static  bool IsPrime(long number)
        {
            int nod = 0;
            long sqrt = (long)Math.Sqrt(number);
            bool squared = sqrt * sqrt == number;
            for (long i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    nod += 2;
                    if (nod > 2 && !squared)
                        return false;
                }
            }

            if (squared)
                nod--;

            return nod == 2;
        }

        public static int GetDigitCount(long n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }

            return count == 0 ? 1 : count;
        }

        public static void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1;
            for (int i = 2; i < len; i++)
            {
                var c = a + b;
                a = b;
                b = c;

                Console.WriteLine($"v --> {c}");
            }
        }

        public static List<long> GetPrimeFactors(long number, bool distinct = false)
        {
            var primes = new List<long>();
            for (int div = 2; div <= number; div++)
            {
                bool added = false;
                while (number % div == 0)
                {
                    if (!distinct || (distinct && !added))
                    {
                        primes.Add(div);
                        added = true;
                    }

                    number = number / div;
                }
            }

            return primes;
        }
    }
}

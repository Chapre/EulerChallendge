using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._37
{
    class TruncatablePrimes : ITestable
    {
        public void Test()
        {
            var sum = 0;
            for (int i = 10; i < 1000000; i++)
            {
                if (IsTruncable(i))
                {
                    sum += i;
                    Console.WriteLine($"Truncable prime --> {i}");
                }
            }

            Console.WriteLine($"Sum is {sum}");
        }

        bool IsTruncable(int n)
        {
            int k = n;
            int length = 0;
            while (k > 0)
            {
                if (!IsPrime(k))
                    return false;
                k /= 10;
                length++;
            }

            k = n;
            while (length > 0)
            {
                if (!IsPrime(k % ((int)Math.Pow(10, length))))
                    return false;
                length--;
            }

            return true;
        }

        bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            return NumberOfDivisors(n) == 2;
        }

        private int NumberOfDivisors(int number)
        {
            int nod = 0;
            int sqrt = (int)Math.Sqrt(number);
            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                    nod += 2;
            }

            if (sqrt * sqrt == number)
            {
                nod--;
            }

            return nod;
        }
    }
}

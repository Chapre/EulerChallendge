using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._35
{
    class CircularPrimes : ITestable
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            int sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                if (!IsCirularPrime(i))
                    continue;

                sum++;
                Console.WriteLine($"{i} ---> circular prime");
            }

            Console.WriteLine($"num of circular prime: {sum}");
        }

        bool IsCirularPrime(int n)
        {
            var shift = n;
            while (true)
            {
                if (!IsPrime(shift))
                    return false;
                shift = ShiftDigits(shift, 1);
                if (shift == n)
                    break;
            }

            return true;
        }


        public int ShiftDigits(int n, int shift)
        {
            var digits = new int[GetDigitCount(n)];
            int indexer = 0;
            while (n > 0)
            {
                digits[indexer] = n % 10;
                indexer++;
                n = n / 10;
            }

            var result = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                int index = (shift + i) % digits.Length;
                if (index < 0)
                    index = index + digits.Length;
                result = result + digits[index] * (int)Math.Pow(10, i);
            }

            return result;
        }

        public int GetDigitCount(int n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }

            return count == 0 ? 1 : count;
        }

        bool IsPrime(int n)
        {
            if (n<=1)
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

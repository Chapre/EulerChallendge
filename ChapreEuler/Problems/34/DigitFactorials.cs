using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._34
{
    class DigitFactorials : ITestable
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            var sum = 0;
            for (int i = 3; i < 10000000; i++)
            {
                if (IsCurious(i))
                {
                    sum = sum + i;
                    Console.WriteLine($"{i} _--> curious");
                }
            }

            Console.WriteLine($"Sum ---> {sum}");
        }

        public bool IsCurious(int number)
        {
            var sum = 0;
            int n = number;
            while (n > 0)
            {
                sum += ComputeFactorial(n % 10);
                if (sum > number)
                    return false;
                n = n / 10;
            }

            return sum == number;
        }

        public int ComputeFactorial(int n)
        {
            int prod = 1;
            for (int i = n; i > 0; i--)
            {
                prod *= i;
            }

            return prod;
        }

        int[] GetDigits(int n)
        {
            List<int> digits = new();
            while (n > 0)
            {
                digits.Insert(0, n % 10);
                n = n / 10;
            }

            return digits.ToArray();
        }
    }
}

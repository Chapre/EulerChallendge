using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._36
{
    class DoubleBasePalindromes : ITestable
    {
        public void Test()
        {
            var sum = 0;
            for (int i = 0; i < 1000000; i++)
            {
                if (IsPalidrome(i, 10) && IsPalidrome(i, 2))
                {
                    sum = sum + i;
                    Console.WriteLine($"Double base Palindrome ---> {i}");
                }
            }

            Console.WriteLine($"Sum is {sum}");

        }

        bool IsPalidrome(int number, int b)
        {
            int result = 0;
            int n = number;
            while (n > 0)
            {
                var d = n % b;
                n = n / b;
                result = result * b + d;
            }

            return result == number;
        }
    }
}

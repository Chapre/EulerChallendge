using System;
using System.Linq;

namespace ChapreEuler
{
    public class Fibbonachi : ITestable
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            var list = Enumerable.Range(0, 4000000).Where(x => IsFibnacci(x) && x % 2 == 0).ToList();
            var sum = list.Sum();
            Console.WriteLine($"{sum}");
            Console.ReadLine();
        }

        /// <summary>
        /// Determines whether the specified value is fibnacci.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>
        ///   <c>true</c> if the specified value is fibnacci; otherwise, <c>false</c>.
        /// </returns>
        public bool IsFibnacci(int value)
        {
            int a = 0, b = 1, c = 0;
            for (;;)
            {
                if (c > value)
                    break;

                c = a + b;
                a = b;
                b = c;

                if (c == value)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the NTH fibonacci ite.
        /// </summary>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        public int GetNthFibonacci_Ite(int n)
        {
            int number = n - 1; //Need to decrement by 1 since we are starting from 0  
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }

            return Fib[number];
        }


        /// <summary>
        /// Fibonaccis the iterative.
        /// </summary>
        /// <param name="len">The length.</param>
        public void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1;
            for (int i = 2; i < len; i++)
            {
                var c = a + b;
                a = b;
                b = c;
            }
        }
    }
}

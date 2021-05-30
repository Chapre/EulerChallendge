using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._38
{
    class PandigitalMultiples : ITestable
    {
        public void Test()
        {
            long max = 0;
            for (long i = 0; i < 10000000; i++)
            {
                if (IsPandigitalMultiplesTest2(i,out var index, out var results, out long number)) {
                    Console.WriteLine($"PandigitalMultiples -->{i} (1 to {index}) on , {number}");
                    if (number>max)
                    {
                        max = number;
                    }
                }
            }
            Console.WriteLine($"Max number ---> {max}");
        }

        public int GetDigitCount(long n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }

            return count == 0 ? 1 : count;
        }

        private bool IsPandigitalMultiplesTest2(long n, out int index, out long[] result, out long numbero)
        {
            for (int i = 1; i < 10; i++)
            {
                long number = 0;
                long[] results = new long[i];
                for (int j = 0; j < results.Length; j++)
                {
                    results[j] = n * (j + 1);
                    int count = GetDigitCount(results[j]);
                    if (j == 0)
                        number = results[0];
                    else
                        number = number * ((long)Math.Pow(10, count)) + results[j];
                }

                index = i;
                if (IsMultiplePandigital(new long[] { number }))
                {
                    result = results;
                    numbero = number;
                    return true;
                }

            }

            numbero = 0;
            result = null;
            index = 0;
            return false;
        }

        private bool IsPandigitalMultiplesTest(int n, out int index, out long[] result)
        {
            for (int i = 1; i < 10; i++)
            {
                long[] results = new long[i];
                for (int j = 0; j < results.Length; j++)
                {
                    results[j] = n * (j + 1);
                }

                index = i;
                if (IsMultiplePandigital(results))
                {
                    result = results;
                    return true;
                }

            }

            result = null;
            index = 0;
            return false;
        }

        bool IsMultiplePandigital(long[] n, int start = 1, int end = 9)
        {
            var flag = new bool[end - start + 1];
            for (int i = 0; i < n.Length; i++)
            {
                for (int j = 0; j < flag.Length; j++)
                {
                    int digit = j + start;
                    int count = ContainDigitCount( n[i], digit);
                    if (count > 1)
                        return false;
                    else if (count == 1)
                    {
                        if (flag[j])
                            return false;
                        flag[j] = true;
                    }
                }
            }

            for (int i = 0; i < flag.Length; i++)
            {
                if (!flag[i])
                    return false;
            }

            return true;
        }

        public int ContainDigitCount(long number, int digit)
        {
            int count = 0;
            if (digit < 0 || digit > 9)
                throw new ArgumentException();
            while (number > 0)
            {
                if (number % 10 == digit)
                    count++;
                number = number / 10;
            }

            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._41
{
    class PandigitalPrime : ITestable
    {
        public void Test()
        {
            var max = 0;
            for (int i = 10; i <987654321; i++)
            {
                if (i % 2 == 0 || i % 3 == 0 || i % 7 == 0)
                    continue;
                var count = QuickHelper.GetDigitCount(i);
                if (!IsPandigital(i, 1, count))
                    continue;
                if (QuickHelper.IsPrime(i) && max<i)
                {
                    max = i;
                    Console.WriteLine($"Pandigital prime  {i}");
                }
            }

            Console.WriteLine("done");
        }

        bool IsPandigital(long number, int start = 1, int end = 9)
        {
            var flag = new bool[end - start + 1];
            for (int j = 0; j < flag.Length; j++)
            {
                int digit = j + start;
                int count = ContainDigitCount(number, digit);
                if (count > 1)
                    return false;
                else if (count == 1)
                {
                    if (flag[j])
                        return false;
                    flag[j] = true;
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

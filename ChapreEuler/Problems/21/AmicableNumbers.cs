using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._21
{
    class AmicableNumbers : ITestable
    {
        public void Test()
        {
            List<int> amicables = new List<int>();
            var amicableSum = 0;
            for (int i = 1; i < 10000; i++)
            {
                var sum = SumProperDivisors(i);
                if (sum!=i && sum < 10000 && SumProperDivisors(sum) == i)
                {
                    Console.WriteLine($"Amicable numbers--> {i}, {sum}");
                    amicableSum += i;
                }
            }

            Console.WriteLine($"Sum ---> {amicableSum}");
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
                    if ((i == sqrt && square)||i==1)
                        continue;
                    sum = sum + num / i;
                }
            }

            return sum;
        }

        List<int> GetProperDivisors(int num)
        {
            List<int> divisors = new List<int>();
            int sqrt = (int)Math.Sqrt(num);
            bool square = sqrt * sqrt == num;
            for (int i = 1; i <= sqrt; i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);
                    if ((i == sqrt && square) || i == 1)
                        continue;
                    divisors.Add(num / i);
                }
            }

            return divisors;
        }

        int SumNumberDigits(int num)
        {
            var sum = 0;
            while (num > 0)
            {
                sum += (int)(num % 10);
                num /= 10;
            }

            return sum;
        }
    }
}

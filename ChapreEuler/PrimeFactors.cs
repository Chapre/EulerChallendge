using System;
using System.Collections.Generic;
using System.Linq;

namespace ChapreEuler
{
    public class PrimeFactors : ITestable
    {
        //public void Test()
        //{
        //    var factors = GetPrimeFactors(600851475143);
        //    Console.WriteLine($"{factors.Display()}");
        //    Console.ReadLine();
        //}
        

        public void Test()
        {
            var divisors = Enumerable.Range(1, 20).ToList();
            long prod = 1;
            for (int i = 0; i < divisors.Count; i++)
            {
                prod = prod * divisors[i];
            }

            for (long i = 1; i < prod; i++)
            {
                if (IsDivvisibleBy(i, divisors))
                {
                    Console.WriteLine(i);
                }
            }
        }


        public bool IsDivvisibleBy(long value, IEnumerable<int> divisors)
        {
            foreach (var divisor in divisors)
            {
                if (value % divisor != 0)
                    return false;
            }

            return true;
        }



        public List<long> GetPrimeFactors(long number)
        {
            var primes = new List<long>();
            for (int div = 2; div <= number; div++)
                while (number % div == 0)
                {
                    primes.Add(div);
                    number = number / div;
                }

            return primes;
        }
    }
}

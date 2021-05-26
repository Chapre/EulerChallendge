using System;
using System.Collections.Generic;

namespace ChapreEuler
{
    public class PrimeFactors : ITestable
    {
        public void Test()
        {
            var factors = GetPrimeFactors(600851475143);
            Console.WriteLine($"{factors.Display()}");
            Console.ReadLine();
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

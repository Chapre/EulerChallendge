using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._12
{
    class TriangularNumber:ITestable
    {
        public void Test()
        {
            //const int n = 7;
            //int term = GetTriangularTerm(n);
            //Console.WriteLine($"{n} ==> {term}, {GetDivisorsCount(term)}");

            //for (ulong n = 1; ; n++)
            //{
            //    ulong term = GetTriangularTerm(n);
            //    int div = GetDivisorsCount(term);
            //    if (n % 1 == 0)
            //    {
            //        Console.WriteLine($"{n} ==> {term}, {div}");
            //    }

            //    if (div >= 5)
            //    {
            //        Console.WriteLine($"{n} ==> {term}, {div}");
            //        break;
            //    }
            //}
            BuildTrangleNumbers();
            //ulong number = 0;
            //ulong i = 1;

            //while (GetDivisorsCount(number) < 500)
            //{
            //    number += i;
            //    i++;

            //}

            //Console.WriteLine(number);
        }

        void BuildTrangleNumbers()
        {
            for (ulong i = 1; i < 100; i++)
            {
                var term = GetTriangularTerm(i);
                var divs= NumberOfDivisors((int)term);
                Console.WriteLine($"{i}th {term}, divs:{divs}");
            }
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
        private int NumberOfDivisors(int number)
        {
            int nod = 0;
            int sqrt = (int)Math.Sqrt(number);

            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    nod += 2;
                }
            }
            //Correction if the number is a perfect square
            if (sqrt * sqrt == number)
            {
                nod--;
            }

            return nod;
        }

        public int GetDivisorsCount(ulong value)
        {
            int count = 0;
            if (value == 1)
                return 1;
            for (uint i = 1; i < value; i++)
            {

                if (value % i == 0)
                {
                    count++;
                }
            }

            return count;
        }

        ulong GetTriangularTerm(ulong n)
        {

            ulong termCount = 0;
            while (true)
            {
                termCount++;
                ulong limit = termCount;
                ulong sum = 0;
                for (ulong i = 1; i <= limit; i++)
                {
                    sum = sum + i;
                }

                if (n == termCount)
                {
                    return sum;
                }
            }
        }
    }
}

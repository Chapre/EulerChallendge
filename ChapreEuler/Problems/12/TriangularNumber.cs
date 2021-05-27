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

            ulong number = 0;
            ulong i = 1;

            while (GetDivisorsCount(number) < 500)
            {
                number += i;
                i++;

            }

            Console.WriteLine(number);
        }

        public int GetDivisorsCount(ulong value)
        {
            int count = 0;
            if (value == 1)
                return 1;
            for (uint i = 1; i < value; i++)
            {
                if (i > value / 2)
                {
                    return count;
                }

                if (value % i == 0)
                {
                    count++;
                    value = value / i;
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

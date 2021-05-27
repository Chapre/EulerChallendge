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
            for (int n = 1;; n++)
            {
                int term = GetTriangularTerm(n);
                int div = GetDivisorsCount(term);
                Console.WriteLine($"{n} ==> {term}, {div}");
                if (div>=500)
                {
                    break;
                }
            }
        }

        public int GetDivisorsCount(long value)
        {
            int count = 0;
            if (value == 1)
                return 1;
            for (int i = 1; i < value; i++)
            {
                if (i > value / 2)
                {
                    return count;
                }

                if (value % i == 0)
                {
                    count++;
                }
            }

            return count;
        }

        int GetTriangularTerm(int n)
        {

            int termCount = 0;
            while (true)
            {
                termCount++;
                int limit = termCount;
                int sum = 0;
                for (int i = 1; i <= limit; i++)
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

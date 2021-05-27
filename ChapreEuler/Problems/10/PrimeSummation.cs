using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._10
{
    class PrimeSummation : ITestable
    {
        bool IsPrime(int value)
        {
            if (value <= 1)
                return false;
            for (int i = 2; i < value; i++)
            {
                if (i > value / 2)
                {
                    return true;
                }

                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public void Test()
        {
            long sum = 0;
            for (int i = 0; i < 2000000; i++)
            {
                if (IsPrime(i))
                    sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}

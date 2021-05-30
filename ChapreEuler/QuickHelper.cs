using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler
{
    public static class QuickHelper
    {
        public static  bool IsPrime(int number)
        {
            int nod = 0;
            int sqrt = (int)Math.Sqrt(number);
            bool squared = sqrt * sqrt == number;
            for (int i = 1; i <= sqrt; i++)
            {
                if (number % i == 0)
                {
                    nod += 2;
                    if (nod > 2 && !squared)
                        return false;
                }
            }

            if (squared)
                nod--;

            return nod == 2;
        }

        public static int GetDigitCount(long n)
        {
            int count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }

            return count == 0 ? 1 : count;
        }
    }
}

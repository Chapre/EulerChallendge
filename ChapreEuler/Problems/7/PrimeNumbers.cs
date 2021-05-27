using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._7
{
    class PrimeNumbers : ITestable
    {
        public void Test()
        {
            int counter = 0;
            int prime = 0;
            while (true)
            {
                if (IsPrime(counter))
                {
                    prime++;
                    Console.WriteLine($"{prime} --> {counter}");
                    if (prime>= 10001)
                    {
                        break;
                    }
                }
                counter++;
            }
        }

        bool IsPrime(int value)
        {
            if (value <= 1)
                return false;
            for (int i = 2; i < value; i++)
            {
                if (value % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}

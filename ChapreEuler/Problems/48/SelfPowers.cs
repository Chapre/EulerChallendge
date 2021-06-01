using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._48
{
    class SelfPowers : ITestable
    {
        public void Test()
        {
            BigInteger sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum = sum + BigInteger.Pow(i, i);
            }

            string output = string.Empty;
            while (sum > 0)
            {
                var d = sum % 10;
                sum = sum / 10;
                output = d + output;
                if (output.Length == 10)
                {
                    Console.WriteLine($"digits are {output}");
                    break;
                }
            }
        }

        
    }
}

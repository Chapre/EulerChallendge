using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._20
{
    public class FactorialDigitSum : ITestable
    {
        public void Test()
        {
            BigInteger prod = 1;
            for (int i = 2; i <= 100; i++)
            {
                prod *= i;
            }

            var tex = prod.ToString("N").Replace(",", string.Empty).Split(new[] { '.' })[0];
            Console.WriteLine(tex);
            long s = tex.Sum(x => (int)char.GetNumericValue(x));
            Console.WriteLine($"{s}");

            //MethodTest1();
        }

        private static void MethodTest1()
        {
            int sum = 0;
            BigInteger prod = 1;
            for (int i = 2; i <= 100; i++)
            {
                prod *= i;
            }

            Console.WriteLine(prod.ToString("N"));
            while (prod > 0)
            {
                sum += (int)(prod % 10);
                prod /= 10;
            }

            Console.WriteLine($"{sum}");
        }
    }
}

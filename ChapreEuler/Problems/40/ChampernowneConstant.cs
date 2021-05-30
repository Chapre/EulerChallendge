using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._40
{
    class ChampernowneConstant : ITestable
    {
        public void Test()
        {
            int walker = 0;
            int generator = 0;
            var prod = 1;
            while (walker < 1000000)
            {
                generator++;
                string s = generator.ToString();

                for (int i = 0; i < s.Length; i++)
                {
                    walker++;
                    if (walker ==1 || walker == 10 || walker == 100 || walker == 1000 ||
                        walker == 10000 || walker == 100000 || walker == 1000000)
                    {
                        Console.WriteLine($"{walker} --> {s[i]}");
                        prod *= (int)(s[i] - '0');
                    }
                }
            }

            Console.WriteLine($"The product is {prod}");
        }
    }
}

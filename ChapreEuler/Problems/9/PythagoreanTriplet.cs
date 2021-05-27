using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._9
{
    class PythagoreanTriplet : ITestable
    {
        public void Test()
        {
            for (int a = 0; a < 1000; a++)
            {
                for (int b = 0; b < 1000; b++)
                {
                    for (int c = 0; c < 1000; c++)
                    {
                        if (c*c == a * a + b * b && c+a+b == 1000)
                        {
                            Console.WriteLine($"{a*b*c}");
                        }
                    }

                }
            }

            Console.WriteLine();
        }
    }
}

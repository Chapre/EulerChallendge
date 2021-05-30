using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._39
{
    class IntegerRightTriangles : ITestable
    {
        public void Test()
        {
            var max = 0;
            for (int p = 0; p < 1000; p++)
            {
                int count = 0;
                for (int a = 0; a < 1000; a++)
                {
                    for (int b = 0; b < 1000; b++)
                    {
                        if (Math.Sqrt(a * a + b * b) + a + b == p)
                        {
                            count++;
                        }
                    }
                }

                if (count > 0 && max < count)
                {
                    max = count;
                    Console.WriteLine($"{p} ---> {count} solutions");
                }
            }

            Console.WriteLine($"Done");
        }
    }
}

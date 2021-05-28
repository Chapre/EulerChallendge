using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._28
{
    class NumberSpiralDiagonal : ITestable
    {
        public void Test()
        {
            ComputeDiagonalSum(500);
        }

        private static void ComputeDiagonalSum(int side)
        {
            long sum = 1;
            for (int i = 1; i <= side; i++)
            {
                long c = (2 * i + 1);
                long c1 = c * c;
                long c2 = c1 - (c - 1);
                long c3 = c2 - (c - 1);
                long c4 = c3 - (c - 1);

                sum += c1 + c2 + c3 + c4;
            }

            Console.WriteLine($"Sum is {sum}");
        }
    }
}

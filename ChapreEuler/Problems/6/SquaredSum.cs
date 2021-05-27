using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._6
{
    class SquaredSum:ITestable
    {
        public void Test()
        {
            var values = Enumerable.Range(1, 100).ToList();
            var sum2 = GetQuaredSum(values);
            var sum1 = GetSum(values);
            Console.WriteLine($"Sum diff --> {sum2- (sum1* sum1)}");
        }

        /// <summary>
        /// Gets the quared sum.
        /// </summary>
        /// <param name="values">The values.</param>
        /// <returns></returns>
        int GetQuaredSum(IEnumerable<int> values)
        {
            return values.Sum(x => x * x);
        }

        int GetSum(IEnumerable<int> values)
        {
            return values.Sum();
        }
    }
}

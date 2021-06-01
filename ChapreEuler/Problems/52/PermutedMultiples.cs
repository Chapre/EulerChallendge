using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._52
{
    public class PermutedMultiples : ITestable
    {
        public void Test()
        {
            var multiplicators = new int[] { 2, 3, 4, 5, 6 };
            for (int i = 0; i < 1000000; i++)
            {
                bool result = true;
                for (int j = 0; j < multiplicators.Length; j++)
                {
                    if (!MathBlog.isPerm(i, i*multiplicators[j]))
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    Console.WriteLine($"Permuted multiples --> {i}");
                }
            }
        }
    }
}

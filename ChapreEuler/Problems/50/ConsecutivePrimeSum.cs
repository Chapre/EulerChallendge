using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._50
{
    class ConsecutivePrimeSum : ITestable
    {
        public void Test()
        {
            int indexer = 0;
            int shift = GetPrimeTerm(indexer);
            int maxcount = 0;
            while (true)
            {
                var count = 0;
                int sum = 0;
                for (int i = shift; i < 1000000; i++)
                {
                    if (QuickHelper.IsPrime(i))
                    {
                        count++;
                        sum = sum + i;
                        if (QuickHelper.IsPrime(sum))
                        {

                            if (maxcount<count)
                            {
                                maxcount = count;
                                Console.WriteLine($"Max Sum is prime {sum} (count:{count}) at shift {shift}");
                            }
                        }

                        if (sum > 1000000)
                            break;
                    }
                }

                indexer++;
                shift = GetPrimeTerm(indexer);
                ///Console.WriteLine(count);
            }


        }

        /// <summary>
        /// Gets the prime term.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public int GetPrimeTerm(int index)
        {
            int counter = 2;
            while (index > 0)
            {
                counter++;
                if (QuickHelper.IsPrime(counter))
                    index--;
            }

            return counter;
        }
    }
}

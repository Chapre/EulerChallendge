using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._14
{
    public class CollatzSequence : ITestable
    {
        public void Test()
        {
            //for (int i = 1; i < 100; i++)
            //{

            //    Console.Write($"{i} --> ");
            //    BuildSequence(i);
            //}

            //Console.WriteLine($"end");
            TestOneMillion();
        }

        private void TestOneMillion()
        {
            long max = 0;
            for (long i = 1; i < 1000000; i++)
            {
                long count = GetSequenceTermCount(i);
                if (count > max)
                {
                    max = count;
                    Console.WriteLine($"{i} --> {max}");
                }

            }

            Console.WriteLine($"end");
        }

        long GetSequenceTermCount(long start)
        {
            long count = 1;
            while (start > 1)
            {
                if (start % 2 == 0)
                {
                    start = start / 2;
                }
                else
                {
                    start = 3 * start + 1;
                }

                count++;
            }

            return count;
        }

        void BuildSequence(int start)
        {
            Console.Write($"{start}");
            while (start > 1)
            {
                if (start % 2 == 0)
                {
                    start = start / 2;
                }
                else
                {
                    start = 3 * start + 1;
                }

                Console.Write($", {start}");
            }

            Console.WriteLine();
        }
    }
}

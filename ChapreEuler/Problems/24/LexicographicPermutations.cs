using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._24
{
    class LexicographicPermutations : ITestable
    {
        private int count;
        private bool cancel;

        public void Test()
        {
            var ints = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Permute(ints, string.Empty, 0);
        }

        void Permute(int[] ints, string term, int depth)
        {
            if (cancel)
            {
                return;
            }

            if (depth >= ints.Length)
            {
                count++;
                Console.WriteLine($"{count}th term --> {term}");
                if (count>=1000000)
                {
                    cancel = true;
                }

                return;
            }

            for (int i = 0; i < ints.Length; i++)
            {
                string permuteTerm = ints[i].ToString();
                if (term.Contains(permuteTerm))
                    continue;
                Permute(ints, term + permuteTerm, depth + 1);
            }
        }
    }
}

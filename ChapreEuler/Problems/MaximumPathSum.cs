using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems
{
    class MaximumPathSum : ITestable
    {
        private int count;

        public void Test()
        {
            var s = @"
75
95 64
17 47 82
18 35 87 10
20 04 82 47 65
19 01 23 75 03 34
88 02 77 73 07 63 67
99 65 04 28 06 16 70 92
41 41 26 56 83 40 80 70 33
41 48 72 33 47 32 37 16 94 29
53 71 44 65 25 43 91 52 97 51 14
70 11 33 28 77 73 17 78 39 68 17 57
91 71 52 38 17 14 91 43 58 50 27 29 48
63 66 04 68 89 53 67 30 73 16 69 87 40 31
04 62 98 27 23 09 70 98 73 93 38 53 60 04 23";
            var splits = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var tree = new int[splits.Length][];
            for (int i = 0; i < splits.Length; i++)
            {
                tree[i] = splits[i].Trim().Split(' ').Select(x => int.Parse(x)).ToArray();
            }

            int sum = 0;
            int level = 0;
            sum = TraverseTreeSum(tree, 0, level, sum);
            Console.WriteLine("");

        }

        private void TraverseTree(int[][] tree,int parentIndex, int level, int sum, string path)
        {
            if (level >= tree.Length)
            {
                count++;
                Console.WriteLine($"{count}  -> {path}");
                return;
            }

            //Console.WriteLine();
            for (int i = 0; i < tree[level].Length; i++)
            {
                if (parentIndex == i -1 || parentIndex == i)
                {
                    var value = tree[level][i];
                    TraverseTree(tree, i, level + 1, sum, path + " " + value.ToString());
                }
            }
        }

        private int TraverseTreeSum(int[][] tree, int parentIndex, int level, int sum)
        {
            if (level >= tree.Length)
            {
                return sum;
            }

            int maxsum = 0;
            //Console.WriteLine();
            for (int i = 0; i < tree[level].Length; i++)
            {
                if (parentIndex == i - 1 || parentIndex == i)
                {
                    var value = tree[level][i];
                    var newSum = TraverseTreeSum(tree, i, level + 1, sum+ value);
                    if (maxsum< newSum)
                    {
                        maxsum = newSum;
                    }
                }
            }

            return maxsum;
        }
    }
}

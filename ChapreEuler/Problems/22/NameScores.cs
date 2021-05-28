using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._22
{
    class NameScores : ITestable
    {
        public void Test()
        {
            string text = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Problems\\22\\names.txt"));
            string[] names = text.Split(new char[] { ',', '"' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(names);
            long totalScore = 0;
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].ToLower();
                var worth = ComputeWorth(name);
                var score = worth * (i + 1);
                totalScore += score;
            }

            Console.WriteLine($"Total score ---> {totalScore}");

        }

        /// <summary>
        /// Computes the worth.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        int ComputeWorth(string name)
        {
            if (name == null || name.Length == 0)
                return 0;
            var sum = 0;
            for (int i = 0; i < name.Length; i++)
            {
                sum += (int)(name[i] - 'a' + 1);
            }

            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._42
{
    class CodedTriangleNumbers : ITestable
    {
        public void Test()
        {
            string text = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Problems\\42\\words.txt"));
            string[] names = text.Split(new char[] { ',', '"' }, StringSplitOptions.RemoveEmptyEntries);
            int count = 0;
            for (int i = 0; i < names.Length; i++)
            {
                string name = names[i].Trim().ToUpper();
                //if (name.Length < 2)
                //    continue;
                int val = SumChars(name);
                int y = 0;
                for (int j = 1; y <= val; j++)
                {
                    y = (j * j + j) / 2;
                    if (y == val)
                    {
                        count++;
                        Console.WriteLine($"Triangle ---> {name}, sum:{y}");
                        continue;
                    }
                }
            }

            Console.WriteLine($"count ---> {count}");
        }

        private int SumChars(string s, char offset='A')
        {
            var sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                sum += (int)(1+s[i]-(offset));
            }

            return sum;
        }
    }
}

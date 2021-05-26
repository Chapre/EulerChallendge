using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler
{
    class Palindrome : ITestable
    {
        bool IsPalidrome(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public void Test()
        {
            int largest = 0;
            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    var product = i * j;
                    if (product > largest && IsPalidrome(product.ToString()))
                    {
                        largest = product;
                        Console.WriteLine($"{largest}");
                    }
                }
            }
        }
    }
}

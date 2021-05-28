using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._25
{
    class FibonacciNumberDigits : ITestable
    {
        public void Test()
        {
            //F1 = 1
            //F2 = 1
            //F3 = 2
            //F4 = 3
            //F5 = 5
            //F6 = 8
            //F7 = 13
            //F8 = 21
            //F9 = 34
            //F10 = 55
            //F11 = 89
            //F12 = 144
            int counter = 0;
            BigInteger a = 0, b = 1;
            string text;
            while (true)
            {
                var c = a + b;
                a = b;
                b = c;
                counter++;
                text = c.ToString();
                if (text.Length == 10)
                {
                    Console.WriteLine($"{counter} --> {c}");
                    break;
                }

                if (counter % 1 == 0)
                {
                    int len = text.Length;
                    Console.WriteLine($"{counter} --> {text.Substring(0, len < 50 ? len : 40)}... ({text.Length})");
                }

            }
        }

        public void Fibonacci_Iterative(int len)
        {
            int a = 0, b = 1;
            for (int i = 2; i < len; i++)
            {
                var c = a + b;
                a = b;
                b = c;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._32
{
    class PandigitalProducts : ITestable
    {
        public void Test()
        {
            int d = 118;
            while (d > 0)
            {
                var r = d % 10;
                Console.WriteLine(r);
                d = d / 10;
            }
            //for (int i = 0; i < 1000; i++)
            //{
            //    var f = isPandigital(i);
            //    if (f)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

        }

        bool isPandigital(int n)
        {
            for (int i = 1; i < 10; i++)
            {
                int count = ContainDigitCount(n, i);
                if (count > 1)
                    return false;
                else if (count == 1)
                    count++;
                else
                    break;
            }

            return false;
        }

        //bool isPandigital2(int n)
        //{
        //    bool []flags=new bool[10];
        //    while (d > 0)
        //    {
        //        if (d % 10 == n)
        //            return true;
        //        d = d / 10;
        //    }

        //    return false;
        //}

        /// <summary>
        /// Contains the digit.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public bool ContainDigit(int d, int n)
        {
            if (n < 0 || n > 9)
                throw new ArgumentException();
            while (d > 0)
            {
                if (d % 10 == n)
                    return true;
                d = d / 10;
            }

            return false;
        }

        /// <summary>
        /// Contains the digit count.
        /// </summary>
        /// <param name="d">The d.</param>
        /// <param name="n">The n.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int ContainDigitCount(int d, int n)
        {
            int count = 0;
            if (n < 0 || n > 9)
                throw new ArgumentException();
            while (d > 0)
            {
                if (d % 10 == n)
                    count++;
                d = d / 10;
            }

            return count;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._17
{
    public class NumberLetterCounts : ITestable
    {
        public void Test()
        {
            //RawTest();
            FormattedTest();
        }

        private void FormattedTest()
        {

            for (int i = 1; i < 1000; i++)
            {
                Console.Write($"{i} --> ");
                if (i >= 1 && i < 10)
                {
                    Console.Write(GetDigit(i));
                }

                if (i >= 10 && i < 20)
                {
                    Console.Write(GetTenth(i));
                }

                if (i >= 20 && i < 100)
                {
                    Console.Write(GetTenth2(i));
                }

                if (i >= 100 && i < 1000)
                {
                    Console.Write(GetHundredths(i));
                }

                Console.WriteLine();
            }
        }

        private void RawTest()
        {
            var sb = new StringBuilder();
            for (int i = 1; i <= 1000; i++)
            {
                if (i >= 1 && i < 10)
                {
                    sb.Append(GetDigit(i));
                }

                if (i >= 10 && i < 20)
                {
                    sb.Append(GetTenth(i));
                }

                if (i >= 20 && i < 100)
                {
                    sb.Append(GetTenth2(i));
                }

                if (i >= 100 && i < 1000)
                {
                    sb.Append(GetHundredths(i));
                }

                if (i==1000)
                {
                    sb.Append("one thousand");
                }
            }

            Console.WriteLine(sb.Length);
        }

        private string GetHundredths(int hundredth)
        {
            if (hundredth < 100 || hundredth > 999)
                throw new ArgumentException();

            var sb = new StringBuilder();
            sb.Append(GetDigit(hundredth / 100));
            sb.Append(' ');
            sb.Append("hundred");
            sb.Append(" and ");
            var part = hundredth % 100;
            if (part >= 1 && part < 10)
            {
                sb.Append(GetDigit(part));
            }

            if (part >= 10 && part < 20)
            {
                sb.Append(GetTenth(part));
            }

            if (part >= 20 && part < 100)
            {
                sb.Append(GetTenth2(part));
            }

            return sb.ToString();
        }

        private string GetTenth2(int tenth2)
        {
            if (tenth2 < 20 || tenth2 > 99)
                throw new ArgumentException();
            string[] tenths2 = {"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
            var sb = new StringBuilder();
            sb.Append(tenths2[tenth2 / 10 - 2]);
            if (tenth2 % 10 != 0)
            {
                sb.Append('-');
                sb.Append(GetDigit(tenth2 % 10));
            }

            return sb.ToString();
        }

        string GetDigit(int digit)
        {
            if (digit < 0 || digit > 9)
                throw new ArgumentException();
            string[] digits = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            return digits[digit];
        }

        string GetTenth(int tenth)
        {
            if (tenth < 10 || tenth > 19)
                throw new ArgumentException();
            string[] tenths = {
                "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen",
                "nineteen"
            };
            return tenths[tenth-10];
        }
    }
}

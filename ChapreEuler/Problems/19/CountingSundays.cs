using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._19
{
    class CountingSundays : ITestable
    {
        public void Test()
        {
            int sundays = 0;
            var daycounter = 1;
            for (int i = 1900; i <= 2000; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    daycounter += GetMonthDays(j, i % 4 == 0 && (i % 100 != 0 || (i % 400 == 0)));
                    if (i >= 1901)
                    {
                        if ((daycounter ) % 7 == 0)
                        {
                            sundays++;
                        }
                    }
                }
            }

            Console.WriteLine(sundays);
        }

        int GetMonthDays(int month, bool leap)
        {
            var months = new int[] { 31, leap ? 29 : 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31  };
            return months[month];
        }
    }
}

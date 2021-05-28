using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._26
{
    class ReciprocalCycles : ITestable
    {
        public void Test()
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalDigits = 20;
            for (int i = 1; i < 100; i++)
            {
                var d = 1.0 / i;
                Console.WriteLine(d.ToString(nfi));
            }
        }

        //string BuidRemainder(int i)
        //{

        //}

        string FindRecursiveTerms(string term)
        {
            var offset = 0;
            var shift = 0;
            while (true)
            {
                offset++;
                for (int i = shift; i < shift + offset; i++)
                {
                    int i2 = i + offset;
                    int i3 = i + 2 * offset;
                    if (i2 >= term.Length || i3 >= term.Length)
                        break;
                    if (term[i] != term[i2] || term[i] != term[i3])
                        break;
                    return term.Substring(i, offset);
                }

                if (term.Length * 1.0 / 3 < offset)
                {
                    shift++;
                    offset = 0;
                }
            }
        }
    }
}

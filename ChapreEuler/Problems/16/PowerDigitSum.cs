using System;
using System.Linq;

namespace ChapreEuler.Problems._16
{
    public class PowerDigitSum : ITestable
    {
        public void Test()
        {
            double val = Math.Pow(2, 1000);
            var tex = val.ToString("N").Replace(",", string.Empty).Split(new []{'.'})[0];
            long s = tex.Sum(x => (int)char.GetNumericValue(x));
            Console.WriteLine($"{s}");
        }
    }
}

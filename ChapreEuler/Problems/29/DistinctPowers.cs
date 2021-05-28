using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._29
{
    class DistinctPowers : ITestable
    {
        public void Test()
        {
            List<BigInteger> list = new List<BigInteger>();
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    BigInteger p = BigInteger.Pow(i, j);
                    list.Add(p);
                }
            }

            Console.WriteLine(list.Distinct().Count());
        }


    }
}

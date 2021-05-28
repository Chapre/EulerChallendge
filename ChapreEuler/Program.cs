using System;
using ChapreEuler.Problems;
using ChapreEuler.Problems._26;

namespace ChapreEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable test = new QuadraticPrimes();
            test.Test();
            Console.ReadLine();
        }
    }
}

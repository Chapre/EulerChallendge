using System;
using ChapreEuler.Problems;
using ChapreEuler.Problems._26;
using ChapreEuler.Problems._28;
using ChapreEuler.Problems._29;
using ChapreEuler.Problems._30;
using ChapreEuler.Problems._31;
using ChapreEuler.Problems._7;

namespace ChapreEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable test = new CoinSum();
            test.Test();
            Console.ReadLine();
        }
    }
}

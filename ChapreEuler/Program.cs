using System;
using ChapreEuler.Problems;
using ChapreEuler.Problems._26;
using ChapreEuler.Problems._28;
using ChapreEuler.Problems._7;

namespace ChapreEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable test = new NumberSpiralDiagonal();
            test.Test();
            Console.ReadLine();
        }
    }
}

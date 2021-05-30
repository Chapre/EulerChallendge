using System;
using ChapreEuler.Problems;
using ChapreEuler.Problems._26;
using ChapreEuler.Problems._28;
using ChapreEuler.Problems._29;
using ChapreEuler.Problems._30;
using ChapreEuler.Problems._31;
using ChapreEuler.Problems._32;
using ChapreEuler.Problems._34;
using ChapreEuler.Problems._35;
using ChapreEuler.Problems._36;
using ChapreEuler.Problems._37;
using ChapreEuler.Problems._38;
using ChapreEuler.Problems._39;
using ChapreEuler.Problems._40;
using ChapreEuler.Problems._41;
using ChapreEuler.Problems._7;

namespace ChapreEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable test = new PandigitalPrime();
            test.Test();
            Console.ReadLine();
        }
    }
}

using System;
using ChapreEuler.Problems._10;
using ChapreEuler.Problems._11;
using ChapreEuler.Problems._12;
using ChapreEuler.Problems._13;
using ChapreEuler.Problems._14;
using ChapreEuler.Problems._6;
using ChapreEuler.Problems._7;
using ChapreEuler.Problems._8;
using ChapreEuler.Problems._9;

namespace ChapreEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable test = new CollatzSequence();
            test.Test();
            Console.ReadLine();

        }
    }
}

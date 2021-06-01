using System;
using ChapreEuler.Problems._42;
using ChapreEuler.Problems._47;
using ChapreEuler.Problems._48;
using ChapreEuler.Problems._50;
using ChapreEuler.Problems._51;
using ChapreEuler.Problems._52;
using ChapreEuler.Problems._53;
using ChapreEuler.Problems._54;

namespace ChapreEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable test = new PokerHands();
            test.Test();
            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}

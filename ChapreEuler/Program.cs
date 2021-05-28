﻿using System;
using ChapreEuler.Problems;
using ChapreEuler.Problems._10;
using ChapreEuler.Problems._11;
using ChapreEuler.Problems._12;
using ChapreEuler.Problems._13;
using ChapreEuler.Problems._14;
using ChapreEuler.Problems._16;
using ChapreEuler.Problems._17;
using ChapreEuler.Problems._20;
using ChapreEuler.Problems._21;
using ChapreEuler.Problems._22;
using ChapreEuler.Problems._23;
using ChapreEuler.Problems._24;
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
            ITestable test = new LexicographicPermutations();
            test.Test();
            Console.ReadLine();
        }
    }
}

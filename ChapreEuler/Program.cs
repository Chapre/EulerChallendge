﻿using System;

namespace ChapreEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable test = new Fibbonachi();
            test.Test();
            Console.ReadLine();

        }
    }
}
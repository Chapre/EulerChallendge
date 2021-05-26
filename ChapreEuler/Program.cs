using System;

namespace ChapreEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            ITestable test = new Palindrome();
            test.Test();
            Console.ReadLine();

        }
    }
}

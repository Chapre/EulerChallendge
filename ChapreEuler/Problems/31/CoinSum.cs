using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapreEuler.Problems._31
{
    class CoinSum : ITestable
    {
        private int count;

        public void Test()
        {
            int[] coins = new int[] {  1, 2, 5, 10, 20, 50, 100, 200 };
            PermuteCoins(coins, 0, string.Empty, 0);
        }

        private void PermuteCoins(int[] coins, int level, string sequence, int sum)
        {
            if (sum>200)
            {
                return;
            }

            if (level >= coins.Length)
            {
                if (sum == 200)
                {
                    count++;
                    Console.WriteLine($"{count} --> {sequence}");
                }

                return;
            }

            for (int i = 0; i < coins.Length; i++)
            {
                int coin = coins[i];
                PermuteCoins(coins, level + 1, sequence + " " + coin.ToString(), sum + coin);
            }
        }
    }
}

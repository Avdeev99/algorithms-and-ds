using System;
using System.Linq;

namespace ConsoleApp1.DynamicProgramming.Medium;

// 322. Coin Change
public class CoinChange
{
    // Time complexity: O(amount * len(coins)); Space complexity: O(amount).
    public int GetCoinChange(int[] coins, int amount)
    {
        var map = Enumerable.Range(0, amount + 1)
            .ToDictionary(item => item, item => amount + 1);

        map[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            foreach (var coin in coins)
            {
                var diff = i - coin;

                if (diff >= 0)
                    map[i] = Math.Min(map[i], 1 + map[diff]);
            }
        }

        return map[amount] == amount + 1 ? -1 : map[amount];
    }
}
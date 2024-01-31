using System;

namespace ConsoleApp1.DynamicProgramming.Easy;

// 121. Best Time to Buy and Sell Stock
public class BestTimeToBuyAndSellStock
{
    // Time complexity: O(n); Space complexity: O(1).
    public int MaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var minPriceForBuy = prices[0];

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPriceForBuy)
                minPriceForBuy = prices[i];

            maxProfit = Math.Max(prices[i] - minPriceForBuy, maxProfit);
        }

        return maxProfit;
    }
}
using System;

namespace ConsoleApp1.BinarySearch.Easy;

// 441. Arranging Coins
public class ArrangingCoins
{
    // Time complexity: O(log(n)); Space complexity: O(1).
    public int ArrangeCoins(int n)
    {
        var l = 0;
        var r = n;

        while (l <= r)
        {
            var mid = l + (r - l) / 2;
            var sum = (double)mid / 2 * (mid + 1);

            if (sum == n)
                return mid;

            if (sum > n)
                r = mid - 1;
            else
                l = mid + 1;
        }

        return r;   
    }
    
    // Time complexity: O(log(n)); Space complexity: O(1).
    public int ArrangeCoins2(int n)
    {
        var left = 0;
        var right = n;
        var result = 0;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            double coinsAmount = (double)mid/2 * (mid + 1);

            if (coinsAmount == n)
                return mid;

            if (coinsAmount < n)
            {
                result = Math.Max(result, mid);
                left = mid + 1;
            }
            else
                right = mid - 1;
        }

        return result;
    }
}
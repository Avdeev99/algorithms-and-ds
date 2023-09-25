using System;

namespace ConsoleApp1.BinarySearch.Easy;

public class ArrangingCoins
{
    // Time complexity: O(log(n)); Space complexity: O(1).
    public int ArrangeCoins(int n)
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

    // Time complexity: O(n); Space complexity: O(1).
    public int ArrangeCoins2(int n)
    {
        var row = 0;

        while (n >= 0)
        {
            row++;
            n -= row;
        }

        return row - 1;
    }
}
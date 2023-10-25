using System;

namespace ConsoleApp1.SlidingWindow.Medium;

public class MinimumSizeSubarraySum
{
    // Time complexity: O(n); Space complexity: O(1).
    public int MinSubArrayLen(int target, int[] nums)
    {
        var sum = 0;
        var result = int.MaxValue;
        var l = 0;

        for (var r = 0; r < nums.Length; r++)
        {
            sum += nums[r];

            while (sum >= target)
            {
                result = Math.Min(result, r - l + 1);
                sum -= nums[l];
                l++;
            }
        }

        return result > nums.Length ? 0 : result;
    }
}
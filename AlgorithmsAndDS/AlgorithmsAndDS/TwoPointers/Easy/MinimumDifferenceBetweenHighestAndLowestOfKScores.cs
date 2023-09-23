using System;

namespace ConsoleApp1.TwoPointers.Easy;

// Time complexity: O(nlog(n)); Space complexity: O(1).
public class MinimumDifferenceBetweenHighestAndLowestOfKScores
{
    public int MinimumDifference(int[] nums, int k)
    {
        Array.Sort(nums);
        var l = 0;
        var r = k - 1;
        var result = int.MaxValue;

        while (r < nums.Length)
        {
            result = Math.Min(result, nums[r] - nums[l]);
            l++;
            r++;
        }

        return result;
    }
}
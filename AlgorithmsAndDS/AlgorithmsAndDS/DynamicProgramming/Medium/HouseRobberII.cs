using System;

namespace ConsoleApp1.DynamicProgramming.Medium;

// 213. House Robber II
public class HouseRobberII
{
    // Time complexity: O(n); Space complexity: O(1).
    public int Rob(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        return Math.Max(
            MaxRob(nums, 0, nums.Length - 1),
            MaxRob(nums, 1, nums.Length)
        );
    }

    private int MaxRob(int[] nums, int start, int length)
    {
        var rob1 = 0;
        var rob2 = 0;

        for (var i = start; i < length; i++)
        {
            var curr = Math.Max(nums[i] + rob1, rob2);
            rob1 = rob2;
            rob2 = curr;
        }

        return rob2;
    }
}
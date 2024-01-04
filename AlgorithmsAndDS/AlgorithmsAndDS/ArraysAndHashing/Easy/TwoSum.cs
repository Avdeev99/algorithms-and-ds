using System.Collections.Generic;

namespace ConsoleApp1.ArraysAndHashing.Easy;

// 1. Two Sum
public class TwoSum
{
    // Time complexity: O(n); Space complexity: O(n).
    public int[] GetTwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
                return new int[] { dict[nums[i]], i };

            var diff = target - nums[i];
            dict[diff] = i;
        }

        return null;
    }
}
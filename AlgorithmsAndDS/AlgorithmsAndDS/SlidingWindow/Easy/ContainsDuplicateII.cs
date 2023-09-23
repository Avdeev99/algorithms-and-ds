﻿using System.Collections.Generic;

namespace ConsoleApp1.SlidingWindow.Easy;

public class ContainsDuplicateII
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]) && i - dict[nums[i]] <= k)
                return true;

            dict[nums[i]] = i;
        }

        return false;
    }
}
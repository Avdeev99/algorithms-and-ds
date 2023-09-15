using System;
using System.Collections.Generic;

namespace ConsoleApp1.ArraysAndHashing.Easy;

public static class FindAllNumbersDisappearedInArray
{
    // Time complexity: O(n); Space complexity: O(1).
    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            var index = Math.Abs(nums[i]) - 1;
            nums[index] = -Math.Abs(nums[index]);
        }

        var result = new List<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                result.Add(i+1);
        }

        return result;
    }
}
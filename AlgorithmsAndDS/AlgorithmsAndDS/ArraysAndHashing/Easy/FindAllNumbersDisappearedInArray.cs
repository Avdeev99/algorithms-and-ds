using System;
using System.Collections.Generic;

namespace ConsoleApp1.ArraysAndHashing.Easy;

// 448. Find All Numbers Disappeared in an Array
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
    
    // Time complexity: O(n); Space complexity: O(1).
    public static IList<int> FindDisappearedNumbers2(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            while (nums[nums[i] - 1] != nums[i])
                (nums[i], nums[nums[i] - 1]) = (nums[nums[i] - 1], nums[i]);
        }

        var result = new List<int>();

        for (var j = 0; j < nums.Length; j++)
        {
            if (nums[j] != j + 1) result.Add(j + 1);
        }

        return result;
    }
    
    // Time complexity: O(n); Space complexity: O(1).
    public static IList<int> FindDisappearedNumbers3(int[] nums)
    {
        var i = 0;
        
        while (i < nums.Length)
        {
            var indexToSwap = nums[i] - 1;
            var currItemOnCorrectPosition = nums[i] == i + 1;
            var itemToSwapOnCorrectPosition = nums[i] != i + 1 && nums[indexToSwap] == indexToSwap + 1;
        
            if (currItemOnCorrectPosition || itemToSwapOnCorrectPosition)
            {
                i++;
                continue;
            }
        
            (nums[i], nums[indexToSwap]) = (nums[indexToSwap], nums[i]);
        }

        var result = new List<int>();

        for (var j = 0; j < nums.Length; j++)
        {
            if (nums[j] != j + 1) result.Add(j + 1);
        }

        return result;
    }
}
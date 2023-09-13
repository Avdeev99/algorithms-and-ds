using System.Linq;

namespace ConsoleApp1.ArraysAndHashing.Easy;

public static class FindPivotIndex
{
    // Time complexity: O(n); Space complexity: O(1)
    public static int PivotIndex(int[] nums)
    {
        var totalSum = nums.Sum();
        var leftSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var rightSum = totalSum - leftSum - nums[i];

            if (leftSum == rightSum) return i;

            leftSum += nums[i];
        }

        return -1;
    }
    
    // Time complexity: O(n); Space complexity: O(n)
    public static int PivotIndex2(int[] nums)
    {
        var postfixSums = new int[nums.Length];
        var postfixSum = 0;

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            postfixSum += nums[i+1];
            postfixSums[i] = postfixSum;
        }

        var prefixSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i != 0)
            {
                prefixSum += nums[i-1];
            }

            if (prefixSum == postfixSums[i]) return i;
        }

        return -1;
    }
}
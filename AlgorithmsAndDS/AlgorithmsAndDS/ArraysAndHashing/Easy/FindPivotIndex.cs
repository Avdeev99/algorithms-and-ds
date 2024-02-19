using System.Linq;

namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 724. Find Pivot Index
public class FindPivotIndex
{
    // Time complexity: O(n); Space complexity: O(1)
    public int PivotIndex(int[] nums)
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
    public int PivotIndex2(int[] nums)
    {
        var rightSideSums = new int[nums.Length];
        var rightSideSum = 0;

        for (var i = nums.Length - 1; i >= 0; i--)
        {
            rightSideSums[i] = rightSideSum;
            rightSideSum += nums[i];
        }

        var leftSideSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (leftSideSum == rightSideSums[i]) return i;

            leftSideSum += nums[i];
        }

        return -1;
    }
}
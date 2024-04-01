namespace AlgorithmsAndDS.Greedy.Medium;

// 53. Maximum Subarray
public class MaximumSubarray
{
    // Time complexity: O(n); Space complexity: O(1).
    public int MaxSubArray(int[] nums)
    {
        var result = nums[0];
        var currSum = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (currSum < 0)
                currSum = nums[i];
            else
                currSum += nums[i];

            result = System.Math.Max(result, currSum);
        }

        return result;   
    }
}
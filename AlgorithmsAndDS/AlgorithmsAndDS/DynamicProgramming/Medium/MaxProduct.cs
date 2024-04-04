namespace AlgorithmsAndDS.DynamicProgramming.Medium;

// 152. Maximum Product Subarray
public class MaxProduct
{
    // Time complexity: O(n); Space complexity: O(1).
    public int GetMaxProduct(int[] nums)
    {
        var result = nums[0];
        var currMin = nums[0];
        var currMax = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] < 0)
                (currMin, currMax) = (currMax, currMin);

            currMax = System.Math.Max(nums[i], currMax * nums[i]);
            currMin = System.Math.Min(nums[i], currMin * nums[i]);

            result = System.Math.Max(result, currMax);
        }

        return result;
    }
}
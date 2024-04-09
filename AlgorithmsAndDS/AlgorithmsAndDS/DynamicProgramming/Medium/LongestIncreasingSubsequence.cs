namespace AlgorithmsAndDS.DynamicProgramming.Medium;

// 300. Longest Increasing Subsequence
public class LongestIncreasingSubsequence
{
    // Time complexity: O(n^2); Space complexity: O(n).
    public int LengthOfLIS(int[] nums)
    {
        var result = 1;
        var lis = new int[nums.Length];
        lis[^1] = 1;

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            lis[i] = 1;

            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] >= nums[j])
                    continue;

                lis[i] = System.Math.Max(lis[i], 1 + lis[j]);
                result = System.Math.Max(lis[i], result);
            }
        }
        
        return result;
    }
}
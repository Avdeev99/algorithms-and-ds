namespace AlgorithmsAndDS.ArraysAndHashing.Medium;

// 238. Product of Array Except Self
public class ProductOfArrayExceptSelf
{
    // Time complexity: O(n); Space complexity: O(1).
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        var prefix = 1;

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = prefix;
            prefix *= nums[i];
        }

        var postfix = nums[^1];

        for (var j = nums.Length - 2; j >= 0; j--)
        {
            result[j] *= postfix;
            postfix *= nums[j];
        }

        return result;
    }
}
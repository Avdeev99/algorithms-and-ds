namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 303. Range Sum Query - Immutable
public class RangeSumQueryImmutable
{
    private readonly int[] _prefixSums;

    // Time complexity: O(n); Space complexity: O(n).
    public RangeSumQueryImmutable(int[] nums)
    {
        _prefixSums = GetPrefixSums(nums);
    }
    
    // Time complexity: O(1); Space complexity: O(1).
    public int SumRange(int left, int right)
    {
        var rightVal = _prefixSums[right];
        var leftVal = left > 0 ? _prefixSums[left - 1] : 0;

        return rightVal - leftVal;
    }
    
    private int[] GetPrefixSums(int[] nums)
    {
        var result = new int[nums.Length];
        var prefixSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            prefixSum += nums[i];
            result[i] = prefixSum;
        }

        return result;
    }
}
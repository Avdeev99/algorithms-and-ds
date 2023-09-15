namespace ConsoleApp1.ArraysAndHashing.Easy;

public class RangeSumQueryImmutable
{
    private readonly int[] _prefixSums;

    // Time complexity: O(n); Space complexity: O(n).
    public RangeSumQueryImmutable(int[] nums)
    {
        _prefixSums = new int[nums.Length];
        var sum = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            _prefixSums[i] = sum;
        }
    }
    
    // Time complexity: O(1); Space complexity: O(1).
    public int SumRange(int left, int right)
    {
        var rightVal = _prefixSums[right];
        var leftVal = left > 0 ? _prefixSums[left - 1] : 0;

        return rightVal - leftVal;
    }
}
namespace AlgorithmsAndDS.BitManipulation.Easy;

// 268. Missing Number
public class MissingNumber
{
    // Time complexity: O(n); Space complexity: O(1).
    public int GetMissingNumber(int[] nums)
    {
        var n = nums.Length;
        var sum = n*(n + 1) / 2;

        foreach (var num in nums)
        {
            sum -= num;
        }

        return sum;
    }
    
    // Time complexity: O(n); Space complexity: O(1).
    public int MissingNumber2(int[] nums)
    {
        var res = 0;
        var i = 0;
        for (i = 0; i < nums.Length; i++)
        {
            res = res ^ i ^nums[i];
        }

        return res ^ i;
    }
}
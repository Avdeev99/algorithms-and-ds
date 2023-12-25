namespace ConsoleApp1.ArraysAndHashing.Easy;

// 1929. Concatenation of Array
public class ConcatenationOfArray
{
    // Time complexity: O(n); Space complexity: O(n).
    public int[] GetConcatenation(int[] nums)
    {
        var result = new int[nums.Length * 2];

        for (var i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i];
            result[i + nums.Length] = nums[i];
        }

        return result;
    }
}
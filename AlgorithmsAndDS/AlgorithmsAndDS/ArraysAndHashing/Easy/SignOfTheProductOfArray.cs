namespace ConsoleApp1.ArraysAndHashing.Easy;

// 1822. Sign of the Product of an Array
public class SignOfTheProductOfArray
{
    // Time complexity: O(n); Space complexity: O(1).
    public int ArraySign(int[] nums)
    {
        var result = 1;

        foreach (var num in nums)
        {
            if (num == 0) return 0;

            if (num < 0)
                result = -result;
        }

        return result;
    }
}
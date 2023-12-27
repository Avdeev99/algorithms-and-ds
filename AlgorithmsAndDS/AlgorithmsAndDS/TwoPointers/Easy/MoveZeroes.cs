namespace ConsoleApp1.TwoPointers.Easy;

// 283. Move Zeroes
public class MoveZeroes
{
    // Time complexity: O(n); Space complexity: O(1).
    public void Move(int[] nums)
    {
        var indexToReplace = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                (nums[i], nums[indexToReplace]) = (nums[indexToReplace], nums[i]);
                indexToReplace++;
            }
        }
    }
}
namespace ConsoleApp1.TwoPointers.Easy;

// 26. Remove Duplicates from Sorted Array
public class RemoveDuplicatesFromSortedArray
{
    // Time complexity: O(n); Space complexity: O(1).
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2) return nums.Length;

        var counter = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] <= nums[i - 1]) continue;

            nums[counter] = nums[i];
            counter++;
        }

        return counter;
    }
}
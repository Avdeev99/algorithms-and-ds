namespace ConsoleApp1.TwoPointers.Easy;

public class RemoveDuplicatesFromSortedArray
{
    // Time complexity: O(n); Space complexity: O(1).
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums.Length;
        }

        var counter = 1;
        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[i-1])
            {
                nums[counter++] = nums[i];
            }
        }
            
        return counter;
    }
}
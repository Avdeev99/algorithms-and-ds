namespace AlgorithmsAndDS.TwoPointers.Medium;

// 80. Remove Duplicates from Sorted Array II
public class RemoveDuplicatesFromSortedArrayII
{
    // Time complexity: O(n); Space complexity: O(1).
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length < 3) return nums.Length;

        var indexToReplace = 2;

        for (var i = 2; i < nums.Length; i++)
        {
            if (nums[i] != nums[indexToReplace - 2])
            {
                nums[indexToReplace] = nums[i];
                indexToReplace++;
            }
        }

        return indexToReplace;
    }
}
namespace AlgorithmsAndDS.LinkedLists.Medium;

// 287. Find the Duplicate Number
public class FindTheDuplicateNumber
{
    // Time complexity: O(n); Space complexity: O(1).
    public int FindDuplicate(int[] nums)
    {
        var slow = 0;
        var fast = 0;

        do
        {
            slow = nums[slow];
            fast = nums[nums[fast]];
        }
        while(slow != fast);

        var slow2 = 0;

        do
        {
            slow = nums[slow];
            slow2 = nums[slow2];
        }
        while(slow != slow2);

        return slow;
    }
}
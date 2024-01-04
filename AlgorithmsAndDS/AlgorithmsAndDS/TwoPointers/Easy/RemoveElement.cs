namespace ConsoleApp1.TwoPointers.Easy;

// 27. Remove Element
public class RemoveElement
{
    // Time complexity: O(n); Space complexity: O(1).
    public int Remove(int[] nums, int val)
    {
        var l = 0;
        var r = nums.Length - 1;

        while(r > 0 && nums[r] == val) r--;

        while (l <= r) 
        {
            if (nums[l] != val)
            {
                l++;
            }
            else
            {
                (nums[l], nums[r]) = (nums[r], nums[l]);
                r--;
            }
        }

        return l;
    }
}
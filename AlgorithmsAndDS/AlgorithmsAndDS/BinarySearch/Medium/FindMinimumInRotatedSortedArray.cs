namespace ConsoleApp1.BinarySearch.Medium;

// 153. Find Minimum in Rotated Sorted Array
public class FindMinimumInRotatedSortedArray
{
    // Time complexity: O(log(n)); Space complexity: O(1).
    public int FindMin(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;

        while (l < r)
        {
            var mid = l + (r - l) / 2;

            if ((mid == 0 || nums[mid] < nums[mid - 1]) && nums[mid] < nums[mid + 1])
                return nums[mid];
            
            if (nums[mid] > nums[r])
                l = mid + 1;
            else
                r = mid - 1;
        }

        return nums[l];
    }
}
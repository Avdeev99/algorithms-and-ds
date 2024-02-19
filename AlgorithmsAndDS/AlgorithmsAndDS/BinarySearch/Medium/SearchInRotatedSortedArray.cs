namespace AlgorithmsAndDS.BinarySearch.Medium;

// 33. Search in Rotated Sorted Array
public class SearchInRotatedSortedArray
{
    // Time complexity: O(log(n)); Space complexity: O(1).
    public int Search(int[] nums, int target)
    {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r)
        {
            var mid = l + (r - l) / 2;

            if (nums[mid] == target)
                return mid;

            if (nums[l] <= nums[mid])
            {
                if (target < nums[mid] && target >= nums[l])
                    r = mid - 1;
                else
                    l = mid + 1;
            }
            else
            {
                if (target > nums[mid] && target <= nums[r])
                    l = mid + 1;
                else
                    r = mid - 1;
            }
        }

        return -1;   
    }
}
namespace ConsoleApp1.BinarySearch.Easy;

// 704. Binary Search
public class BinarySearch
{
    // Time complexity: O(log(n)); Space complexity: O(1).
    public int Search(int[] nums, int target)
    {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r)
        {
            var mid = l + (r - l) / 2;

            if (nums[mid] == target) return mid;
            else if (target > nums[mid])
                l = mid + 1;
            else
                r = mid - 1;
        }

        return -1;
    }
}
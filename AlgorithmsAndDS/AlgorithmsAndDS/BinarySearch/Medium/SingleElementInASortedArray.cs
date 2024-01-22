namespace ConsoleApp1.BinarySearch.Medium;

// 540. Single Element in a Sorted Array
public class SingleElementInASortedArray
{
    // Time complexity: O(log(n)); Space complexity: O(1).
    public int SingleNonDuplicate(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;

        while (l <= r)
        {
            var mid = l + (r - l) / 2;
            var leftItemSame = mid > 0 && nums[mid-1] == nums[mid];
            var rightItemSame = mid + 1 < nums.Length && nums[mid+1] == nums[mid];
            var appearsOnce = !leftItemSame && !rightItemSame;

            if (appearsOnce)
                return nums[mid];

            var leftSize = leftItemSame ? mid - 1 : mid;

            if (leftSize % 2 == 0)
                l = mid + 1;
            else
                r = mid - 1;
        }

        return l;
    }
}
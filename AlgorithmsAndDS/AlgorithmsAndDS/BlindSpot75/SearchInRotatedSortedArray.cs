using System.Linq;

namespace AlgorithmsAndDS.BlindSpot75;

public static class SearchInRotatedSortedArray
{
    public static int Search(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;
        var pivotIndex = 0;
        var targetIndex = -1;

        while (left < right)
        {
            if (nums[left] > nums[left+1])
            {
                pivotIndex = left+1;
                break;
            }

            if (nums[right-1] > nums[right])
            {
                pivotIndex = right;
                break;
            }

            left++;
            right--;
        }

        if (target == nums[pivotIndex]) return pivotIndex;
        else if (target > nums[pivotIndex] && target <= nums[nums.Length-1])
            nums = nums.Skip(pivotIndex).ToArray();
        else nums = nums.Take(pivotIndex).ToArray();

        left = 0;
        right = nums.Length - 1;

        while (left <= right)
        {
            var middle = left + (right - left)/2;

            if(nums[middle] == target) return middle;
            else if (target > nums[middle])  left = middle+1;
            else right = middle-1;
        }


        return targetIndex; 
    }
}
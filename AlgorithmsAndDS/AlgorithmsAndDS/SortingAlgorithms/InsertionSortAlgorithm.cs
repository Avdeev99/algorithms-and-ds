namespace ConsoleApp1.SortingAlgorithms;

public static class InsertionSortAlgorithm
{
    // Time complexity: O(n^2); Space complexity: O(1)
    public static int[] InsertionSort(int[] nums)
    {
        for (var i = 1; i < nums.Length; i++)
        {
            var j = i - 1;
			
            while (j >= 0 && nums[j+1] < nums[j])
            {
                (nums[j + 1], nums[j]) = (nums[j], nums[j + 1]);
                j--;
            }
        }
		
        return nums;
    }
}
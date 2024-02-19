namespace AlgorithmsAndDS.SortingAlgorithms;

public static class BubbleSortAlgorithm
{
    // Time complexity: O(n^2); Space complexity: O(1)
    public static int[] BubbleSort(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = 0; j < nums.Length-1; j++)
            {
                if (nums[j] > nums[j+1])
                {
                    (nums[j], nums[j+1]) = (nums[j+1], nums[j]);
                }
            }
        }
		
        return nums;
    }
}
namespace AlgorithmsAndDS.SortingAlgorithms;

public static class SelectionSortAlgorithm
{
    // Time complexity: O(n^2); Space complexity: O(1)
    public static int[] SelectionSort(int[] nums)
    {
        for (var i = 0; i < nums.Length-1; i++)
        {
            var minIndex = i;
			
            for (var j = i+1; j < nums.Length; j++)
            {
                if (nums[j] < nums[minIndex])
                    minIndex = j;
            }
			
            (nums[minIndex], nums[i]) = (nums[i], nums[minIndex]);
        }
		
        return nums;
    }
}
namespace AlgorithmsAndDS.ArraysAndHashing.Medium;

public class SortColors
{
    // Time complexity: O(n); Space complexity: O(1).
    public void Sort(int[] nums)
    {
        var zeroIndex = 0;
        var twoIndex = nums.Length- 1;

        var i = 0;

        while (i <= twoIndex)
        {
            if (nums[i] == 0)
            {
                (nums[i], nums[zeroIndex]) = (nums[zeroIndex], nums[i]);
                zeroIndex++;
            }
            else if (nums[i] == 2)
            {
                (nums[i], nums[twoIndex]) = (nums[twoIndex], nums[i]);
                twoIndex--;
                i--;
            }

            i++;
        }
    }
}
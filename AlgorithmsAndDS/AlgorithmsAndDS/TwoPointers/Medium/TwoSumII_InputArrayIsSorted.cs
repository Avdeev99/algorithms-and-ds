namespace AlgorithmsAndDS.TwoPointers.Medium;

// 167. Two Sum II - Input Array Is Sorted
public class TwoSumII_InputArrayIsSorted
{
    // Time complexity: O(n); Space complexity: O(1).
    public int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;

        while (left < right)
        {
            var sum = numbers[left] + numbers[right];

            if (sum > target)
                right--;
            else if (sum < target)
                left++;
            else
                return new int[] { left + 1, right + 1 };
        }

        return new int[] {};
    }
}
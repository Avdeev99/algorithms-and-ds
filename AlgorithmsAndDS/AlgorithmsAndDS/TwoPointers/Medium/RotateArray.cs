namespace AlgorithmsAndDS.TwoPointers.Medium;

// 189. Rotate Array
public class RotateArray
{
    // Time complexity: O(n); Space complexity: O(1).
    // At first rotate whole array.
    // Secondly rotate only first k elements (those elements that we want to shift)
    // Rotate other elements after k elements.
    public void Rotate(int[] nums, int k)
    {
        k = k % nums.Length;

        Reverse(nums, 0, nums.Length - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, nums.Length - 1);
    }

    private void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            (nums[left], nums[right]) = (nums[right], nums[left]);
            left++;
            right--;
        }
    }
}
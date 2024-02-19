namespace AlgorithmsAndDS.TwoPointers.Medium;

// 11. Container With Most Water
public class ContainerWithMostWater
{
    // Time complexity: O(n); Space complexity: O(1).
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var maxArea = int.MinValue;

        while (left < right)
        {
            var l = right - left;
            var h = Math.Min(height[left], height[right]);
            var area = l * h;
            maxArea = Math.Max(area, maxArea);

            if (height[left] > height[right])
                right--;
            else
                left++;
        }

        return maxArea;
    }
}
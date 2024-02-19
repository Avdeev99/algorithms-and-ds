namespace AlgorithmsAndDS.SlidingWindow.Easy;

// 1984. Minimum Difference Between Highest and Lowest of K Scores
public class MinimumDifferenceBetweenHighestAndLowestOfKScores
{
    // Time complexity: O(nlog(n)); Space complexity: O(1).
    public int MinimumDifference(int[] nums, int k)
    {
        Array.Sort(nums);

        var l = 0;
        var r = k - 1;
        var min = int.MaxValue;

        while (r < nums.Length)
        {
            var diff = nums[r] - nums[l];
            min = Math.Min(min, diff);

            l++;
            r++;
        }

        return min;
    }
}
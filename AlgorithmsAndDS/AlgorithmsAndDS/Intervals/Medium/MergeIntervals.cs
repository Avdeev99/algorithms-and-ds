namespace AlgorithmsAndDS.Intervals.Medium;

// 56. Merge Intervals
public class MergeIntervals
{
    // Time complexity: O(n*log(n)); Space complexity: O(n).
    public int[][] Merge(int[][] intervals)
    {
        Array.Sort(intervals, (arr1, arr2) => arr1[0] - arr2[0]);
        var result = new List<int[]>();
        var first = intervals[0];

        for (var i = 1; i < intervals.Length; i++)
        {
            var second = intervals[i];

            if (first[1] < second[0])
            {
                result.Add(first);
                first = second;
            }
            else
            {
                var merged = new int[] { first[0], System.Math.Max(first[1], second[1]) };
                first = merged;
            }
        }

        result.Add(first);

        return result.ToArray();    
    }
}
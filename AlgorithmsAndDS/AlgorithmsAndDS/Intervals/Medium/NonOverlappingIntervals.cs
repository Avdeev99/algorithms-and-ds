namespace AlgorithmsAndDS.Intervals.Medium;

// 435. Non-overlapping Intervals
public class NonOverlappingIntervals
{
    // Time complexity: O(n*log(n)); Space complexity: O(n).
    public int EraseOverlapIntervals(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0] - b[0]);

        var result = 0;
        var prevEnd = intervals[0][1];

        for (var i = 1; i < intervals.Length; i++)
        {
            var start = intervals[i][0];
            var end = intervals[i][1];

            if (start >= prevEnd)
                prevEnd = end;
            else
            {
                result++;
                prevEnd = System.Math.Min(prevEnd, end);
            }
        }

        return result;   
    }
}
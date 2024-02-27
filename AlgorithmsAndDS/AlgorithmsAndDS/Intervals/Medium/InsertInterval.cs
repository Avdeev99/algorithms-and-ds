namespace AlgorithmsAndDS.Intervals.Medium;

// 57. Insert Interval
public class InsertInterval
{
    // Time complexity: O(n); Space complexity: O(n).
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var result = new List<int[]>();
        var isInserted = false;

        foreach (var interval in intervals)
        {
            if (!isInserted && interval[0] > newInterval[1])
            {
                result.Add(newInterval);
                isInserted = true;
            }

            if (interval[1] < newInterval[0] || interval[0] > newInterval[1])
            {
                result.Add(interval);
                continue;
            }

            newInterval = new int[]
            { 
                System.Math.Min(interval[0], newInterval[0]),
                System.Math.Max(interval[1], newInterval[1]),
            };
        }

        if (!isInserted)
            result.Add(newInterval);

        return result.ToArray();
    }
}
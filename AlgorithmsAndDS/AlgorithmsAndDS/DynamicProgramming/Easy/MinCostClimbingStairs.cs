namespace AlgorithmsAndDS.DynamicProgramming.Easy;

// 746. Min Cost Climbing Stairs
public class MinCostClimbingStairs
{
    // Time complexity: O(n); Space complexity: O(1).
    public int GetMinCostClimbingStairs(int[] cost)
    {
        var prev1 = cost[1];
        var prev2 = cost[0];

        for (var i = 2; i < cost.Length; i++)
        {
            var min = Math.Min(prev1, prev2);
            prev2 = prev1;
            prev1 = min + cost[i];
        }

        return Math.Min(prev1, prev2);
    }
}
namespace AlgorithmsAndDS.DynamicProgramming.Medium;

// 198. House Robber
public class HouseRobber
{
    // Time complexity: O(n); Space complexity: O(1).
    public int Rob(int[] nums)
    {
        var rob1 = 0;
        var rob2 = 0;

        foreach (var num in nums)
        {
            var curr = Math.Max(rob2, num + rob1);
            rob1 = rob2;
            rob2 = curr;
        }

        return rob2;
    }
}
namespace AlgorithmsAndDS.DynamicProgramming.Easy;

// 70. Climbing Stairs
public class ClimbingStairs
{
    // Time complexity: O(n); Space complexity: O(1).
    public int ClimbStairs(int n)
    {
        if (n <= 2) return n;

        var prev1 = 2;
        var prev2 = 1;

        for (var i = 3; i <= n; i++)
        {
            var curr = prev1 + prev2;
            prev2 = prev1;
            prev1 = curr;
        }   

        return prev1;
    }
}
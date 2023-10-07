namespace ConsoleApp1.DynamicProgramming.Easy;

public class NTribonacciNumber
{
    // Time complexity: O(n); Space complexity: O(1).
    public int Tribonacci(int n)
    {
        if (n <= 2)
            return n == 0 ? 0 : 1;
        
        var prev3 = 0;
        var prev2 = 1;
        var prev1 = 1;

        for (var i = 3; i <= n; i++)
        {
            var curr = prev1 + prev2 + prev3;

            prev3 = prev2;
            prev2 = prev1;
            prev1 = curr;
        }

        return prev1;
    }
}
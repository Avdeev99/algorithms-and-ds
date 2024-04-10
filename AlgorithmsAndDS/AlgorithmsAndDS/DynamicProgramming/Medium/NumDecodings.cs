namespace AlgorithmsAndDS.DynamicProgramming.Medium;

// 91. Decode Ways
public class NumDecodings
{
    // Time complexity: O(n); Space complexity: O(1).
    public int GetNumDecodings(string s)
    {
        var dp1 = 1;
        var dp2 = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var temp = s[i] == '0' ? 0 : dp1;

            if (i < s.Length - 1 &&
                (s[i] == '1' || s[i] == '2' && s[i + 1] < '7'))
            {
                temp += dp2;
            }

            dp2 = dp1;
            dp1 = temp;
        }

        return dp1;   
    }
}
namespace AlgorithmsAndDS.DynamicProgramming.Medium;

// 139. Word Break
public class WordBreak
{
    // Time complexity: O(n * m * k); Space complexity: O(n).
    public bool IsWordBreak(string s, IList<string> wordDict)
    {
        var dp = new bool[s.Length + 1];
        dp[^1] = true;
        
        for (var i = s.Length - 1; i >= 0; i--)
        {
            foreach (var word in wordDict)
            {
                var isEqual = i + word.Length <= s.Length &&
                              s.Substring(i, word.Length) == word;

                if (isEqual)
                    dp[i] = dp[i + word.Length];

                if (dp[i])
                    break;
            }
        }

        return dp[0];
    }
}
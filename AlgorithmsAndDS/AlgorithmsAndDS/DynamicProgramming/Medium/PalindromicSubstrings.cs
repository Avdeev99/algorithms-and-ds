namespace AlgorithmsAndDS.DynamicProgramming.Medium;

// 647. Palindromic Substrings
public class PalindromicSubstrings
{
    // Time complexity: O(n^2); Space complexity: O(1).
    public int CountSubstrings(string s)
    {
        var result = 0;

        for (var i = 0; i < s.Length; i++)
        {
            result += CountPalindroms(s, i, i);
            result += CountPalindroms(s, i, i + 1);
        }

        return result;
    }

    private int CountPalindroms(string s, int l, int r)
    {
        var count = 0;

        while (l >= 0 && r < s.Length && s[l] == s[r])
        {
            count++;
            l--;
            r++;
        }

        return count;
    }
}
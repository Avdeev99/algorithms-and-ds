namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 392. Is Subsequence
public class IsSubsequence
{
    // Time complexity: O(n); Space complexity: O(1).
    public bool IsValid(string s, string t)
    {
        var tIndex = 0;
        var sIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (t[tIndex] == s[sIndex]) sIndex++;

            tIndex++;
        }

        return sIndex == s.Length;
    }
}
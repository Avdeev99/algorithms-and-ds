using System.Text;

namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 14. Longest Common Prefix
public class LongestCommonPrefix
{
    // Time complexity: O(mn); Space complexity: O(k).
    public string GetLongestCommonPrefix(string[] strs)
    {
        var res = new StringBuilder();

        for (int i = 0; i < strs[0].Length; i++)
        {
            foreach (var s in strs)
            {
                if (i == s.Length || s[i] != strs[0][i])
                    return res.ToString();
            }

            res.Append(strs[0][i]);
        }

        return res.ToString();
    }
    
    // Time complexity: O(mnlog(n)); Space complexity: O(k).
    public string LongestCommonPrefix2(string[] strs)
    {
        if (strs.Length < 1) return string.Empty;

        Array.Sort(strs);

        var firstWord = strs[0];
        var lastWord = strs[^1];

        var i = 0;
        var result = new StringBuilder();

        while (i < firstWord.Length && i < lastWord.Length && firstWord[i] == lastWord[i])
        {
            result.Append(firstWord[i]);
            i++;
        }

        return result.ToString();
    }
}
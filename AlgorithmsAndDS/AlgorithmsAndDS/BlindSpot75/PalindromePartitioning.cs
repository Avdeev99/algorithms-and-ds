using System.Linq;

namespace AlgorithmsAndDS.BlindSpot75;

public static class PalindromePartitioning
{
    public static IList<IList<string>> Partition(string s) {
        var result = new List<IList<string>>();
        var part = new List<string>();

        Backtrack(s, 0, part, result);

        return result;
    }

    private static void Backtrack(
        string s,
        int index,
        List<string> part,
        List<IList<string>> result)
    {
        if (index >= s.Length)
        {
            result.Add(part.ToList());
            return;
        }

        for (var j = index; j < s.Length; j++)
        {
            if (IsPalindrome(s, index, j))
            {
                part.Add(s.Substring(index, j - index + 1));

                Backtrack(s, j+1, part, result);

                part.RemoveAt(part.Count - 1);
            }
        }
    }

    private static bool IsPalindrome(string s, int l, int r)
    {
        while (l < r)
        {
            if (s[l] != s[r])
                return false;
            l++;
            r--;
        }

        return true;
    }
}
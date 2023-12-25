using System.Collections.Generic;

namespace ConsoleApp1.ArraysAndHashing.Easy;

// 242. Valid Anagram
public class ValidAnagram
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var dict = new Dictionary<char, int>();

        foreach (var c in s)
        {
            if (dict.ContainsKey(c))
                dict[c]++;
            else
                dict[c] = 1;
        }

        foreach (var c in t)
        {
            if (dict.ContainsKey(c))
                dict[c]--;
            else
                return false;
        }

        foreach (var (_, value) in dict)
        {
            if (value > 0)
                return false;
        }

        return true;
    }
}
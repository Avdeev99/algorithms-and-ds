using System;
using System.Collections.Generic;

namespace ConsoleApp1.SlidingWindow.Medium;

// 3. Longest Substring Without Repeating Characters
public class LongestSubstringWithoutRepeatingCharacters
{
    // Time complexity: O(n); Space complexity: O(k).
    public int LengthOfLongestSubstring(string s)
    {
        var set = new HashSet<char>();

        var l = 0;
        var max = 0;

        for (var r = 0; r < s.Length; r++)
        {
            while (set.Contains(s[r]))
            {
                set.Remove(s[l]);
                l++;
            }

            set.Add(s[r]);
            max = Math.Max(max, r - l + 1);
        }

        return max;
    }
}
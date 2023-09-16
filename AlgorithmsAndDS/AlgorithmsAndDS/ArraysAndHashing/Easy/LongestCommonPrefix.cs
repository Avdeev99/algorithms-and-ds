using System;

namespace ConsoleApp1.ArraysAndHashing.Easy;

public class LongestCommonPrefix
{
    // Time complexity: O(nlog(n)); Space complexity: O(1).
    public string GetLongestCommonPrefix(string[] strs)
    {
        Array.Sort(strs);

        var first = strs[0];
        var last = strs[strs.Length - 1];

        var index = 0;

        while (index < first.Length && index < last.Length)
        {
            if (first[index] != last[index]) break;
            index++;
        }

        return first.Substring(0, index);
    }
}
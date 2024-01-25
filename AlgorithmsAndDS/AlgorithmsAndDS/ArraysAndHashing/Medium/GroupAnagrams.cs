using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.ArraysAndHashing.Medium;

// 49. Group Anagrams
public class GroupAnagrams
{
    // Time complexity: O(nm); Space complexity: O(n).
    public IList<IList<string>> Group(string[] strs)
    {
        var groups = new Dictionary<string, IList<string>>();

        foreach (string s in strs)
        {
            var hash = new char[26];

            foreach (char c in s)
                hash[c - 'a']++;
            
            var key = new string(hash);

            if (!groups.ContainsKey(key))
                groups[key] = new List<string>();

            groups[key].Add(s);
        }
        
        return groups.Values.ToList();
    }
}
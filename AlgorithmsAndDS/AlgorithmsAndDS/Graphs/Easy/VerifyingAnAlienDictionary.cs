using System.Collections.Generic;

namespace ConsoleApp1.Graphs.Easy;

public class VerifyingAnAlienDictionary
{
    // Time complexity: O(n), n - total number of characters in words;
    // Space complexity: O(1).
    public bool IsAlienSorted(string[] words, string order)
    {
        var orderDict = new Dictionary<char, int>();

        for (var i = 0; i < order.Length; i++)
        {
            orderDict[order[i]] = i;
        }

        for (var i = 0; i < words.Length - 1; i++)
        {
            var word1 = words[i];
            var word2 = words[i+1];

            for (var j = 0; j < word1.Length; j++)
            {
                if (j == word2.Length)
                    return false;

                if (word1[j] == word2[j])
                    continue;

                if (orderDict[word1[j]] > orderDict[word2[j]])
                    return false;
                else
                    break;
            }
        }

        return true;
    }
}
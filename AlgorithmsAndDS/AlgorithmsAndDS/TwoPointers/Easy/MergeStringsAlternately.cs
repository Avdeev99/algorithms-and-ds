using System.Text;

namespace AlgorithmsAndDS.TwoPointers.Easy;

// 1768. Merge Strings Alternately
public class MergeStringsAlternately
{
    // Time complexity: O(n); Space complexity: O(n+m).
    public string MergeAlternately(string word1, string word2)
    {
        var result = new StringBuilder();
        var index = 0;

        while (index < word1.Length || index < word2.Length)
        {
            if (index < word1.Length)
                result.Append(word1[index]);

            if (index < word2.Length)
                result.Append(word2[index]);
           
            index++;
        }

        return result.ToString();
    }
}
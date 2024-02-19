namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 290. Word Pattern
public class WordPattern
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool IsWordPattern(string pattern, string s)
    {
        var words = s.Split(' ');

        if (words.Length != pattern.Length)
            return false;

        var pMap = new Dictionary<char, string>();
        var sMap = new Dictionary<string, char>();

        for (var i = 0; i < pattern.Length; i++)
        {
            var c = pattern[i];
            var word = words[i];

            if (pMap.ContainsKey(c) && pMap[c] != word)
                return false;
            
            if (sMap.ContainsKey(word) && sMap[word] != c)
                return false;
            
            pMap[c] = word;
            sMap[word] = c;
        }

        return true;
    }
}
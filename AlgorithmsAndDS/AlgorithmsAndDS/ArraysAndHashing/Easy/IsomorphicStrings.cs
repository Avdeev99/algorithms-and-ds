namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 205. Isomorphic Strings
public class IsomorphicStrings
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var mapST = new Dictionary<char, char>();
        var mapTS = new Dictionary<char, char>();

        for (int i = 0; i < s.Length; i++) {
            var sChar = s[i];
            var tChar = t[i];

            if (mapST.ContainsKey(sChar) && mapST[sChar] != tChar) 
                return false;
            else
                mapST[sChar] = tChar;

            if (mapTS.ContainsKey(tChar) && mapTS[tChar] != sChar)
                return false;
            else
                mapTS[tChar] = sChar;
        }

        return true;
    }
}
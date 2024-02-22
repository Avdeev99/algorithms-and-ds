namespace AlgorithmsAndDS.SlidingWindow.Medium;

// 424. Longest Repeating Character Replacement
public class LongestRepeatingCharacterReplacement
{
    // Time complexity: O(n); Space complexity: O(1).
    public int CharacterReplacement(string s, int k)
    {
        var left = 0;
        var right = 0;
        var letters = new Dictionary<char, int>();
        var maxFreq = 0;
        var result = 0;

        while (right < s.Length)
        {
            if (letters.ContainsKey(s[right]))
                letters[s[right]]++;
            else
                letters[s[right]] = 1;

            maxFreq = Math.Max(maxFreq, letters[s[right]]);

            var currLength = right - left + 1;

            while (currLength - maxFreq > k)
            {
                letters[s[left]]--;
                left++;
                currLength = right - left + 1;
            }

            result = System.Math.Max(result, currLength);
            right++;
        }

        return result;
    }
}
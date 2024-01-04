namespace ConsoleApp1.ArraysAndHashing.Easy;

// 58. Length of Last Word
public class LengthOfLastWord
{
    // Time complexity: O(n); Space complexity: O(1).
    public int GetLengthOfLastWord(string s)
    {
        if (s.Length == 0) return 0;

        var result = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            var isSpace = s[i] == ' ';

            if (result > 0 && isSpace) break;

            if (!isSpace) result++;
        }

        return result;
    }
}
namespace AlgorithmsAndDS.DynamicProgramming.Medium;

// 5. Longest Palindromic Substring
public class LongestPalindromicSubstring
{
    // Time complexity: O(n^2); Space complexity: O(1).
    public string LongestPalindrome(string s)
    {
        var res = string.Empty;

        void FindPalindrome(int l, int r)
        {
            while (l >= 0 && r < s.Length && s[l] == s[r])
            {
                var currLength = r - l + 1;

                if (res.Length < currLength)
                    res = s.Substring(l, currLength);

                l -= 1;
                r += 1;
            }
        }

        for (var i = 0; i < s.Length; i++)
        {
            // odd length
            FindPalindrome(i, i);

            // even length
            FindPalindrome(i, i + 1);
        }

        return res;
    }
}
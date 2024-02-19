namespace AlgorithmsAndDS.TwoPointers.Easy;

// 125. Valid Palindrome
public class ValidPalindrome
{
    // Time complexity: O(n); Space complexity: O(1).
    public bool IsPalindrome(string s)
    {
        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            if (!char.IsLetterOrDigit(s[l]))
            {
                l++;
                continue;
            }

            if (!char.IsLetterOrDigit(s[r]))
            {
                r--;
                continue;
            }
            
            if (char.ToLower(s[l]) != char.ToLower(s[r]))
                return false;
            
            l++;
            r--;
        }

        return true;
    }
}
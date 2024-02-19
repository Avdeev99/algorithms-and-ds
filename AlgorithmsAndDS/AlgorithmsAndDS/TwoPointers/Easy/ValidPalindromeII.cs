namespace AlgorithmsAndDS.TwoPointers.Easy;

// 680. Valid Palindrome II
public class ValidPalindromeII
{
    // Time complexity: O(n); Space complexity: O(1).
    public bool ValidPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left <= right)
        {
            if (s[left] != s[right])
                return IsPalindrome(s, left+1, right) || IsPalindrome(s, left, right-1);

            left++;
            right--;
        }

        return true;
    }

    private bool IsPalindrome(string s, int left, int right)
    {
        while (left <= right)
        {
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
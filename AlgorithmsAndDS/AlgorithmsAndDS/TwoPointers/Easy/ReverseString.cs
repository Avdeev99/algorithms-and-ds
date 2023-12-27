namespace ConsoleApp1.TwoPointers.Easy;

// 344. Reverse String
public class ReverseString
{
    // Time complexity: O(n); Space complexity: O(1).
    public void Reverse(char[] s)
    {
        var l = 0;
        var r = s.Length - 1;

        while (l < r)
        {
            (s[l], s[r]) = (s[r], s[l]);
            l++;
            r--;
        }
    }
}
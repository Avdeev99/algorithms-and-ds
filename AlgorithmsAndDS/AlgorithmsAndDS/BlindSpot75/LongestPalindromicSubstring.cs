using System.Linq;
using System.Text;

namespace AlgorithmsAndDS.BlindSpot75
{
    public static class LongestPalindromicSubstring
    {
        public static string LongestPalindrome(string s)
        {
            var resultStr = string.Empty;
            var resultStrLength = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var l = i;
                var r = i;

                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    var palindromeLength = r - l + 1;
                    if (palindromeLength > resultStrLength)
                    {
                        resultStr = s.Substring(l, palindromeLength);
                        resultStrLength = palindromeLength;
                    }

                    l -= 1;
                    r += 1;
                }

                l = i;
                r = i + 1;
                
                while (l >= 0 && r < s.Length && s[l] == s[r])
                {
                    var palindromeLength = r - l + 1;
                    if (palindromeLength > resultStrLength)
                    {
                        resultStr = s.Substring(l, palindromeLength);
                        resultStrLength = palindromeLength;
                    }

                    l -= 1;
                    r += 1;
                }
            }

            return resultStr;
        }

        public static string LongestPalindrome2(string s)
        {
            var result = string.Empty;

            if (s.Length == 1)
            {
                return s;
            }

            for (var i = 0; i < s.Length - 1; i++)
            {
                var stringBuilder = new StringBuilder();
                stringBuilder.Append(s[i]);
                
                for (var j = i + 1; j < s.Length; j++)
                {
                    stringBuilder.Append(s[j]);

                    var reverseStr = new string(stringBuilder.ToString().Reverse().ToArray());

                    var isPalindromic = reverseStr == stringBuilder.ToString();

                    if (isPalindromic && reverseStr.Length > result.Length)
                    {
                        result = reverseStr;
                    }
                }
            }

            return result;
        }
    }
}
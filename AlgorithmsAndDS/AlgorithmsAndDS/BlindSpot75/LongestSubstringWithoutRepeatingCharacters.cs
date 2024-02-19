using System.Linq;

namespace AlgorithmsAndDS.BlindSpot75
{
    public static class LongestSubstringWithoutRepeatingCharacters
    {
        public static int LengthOfLongestSubstring(string s)
        {
            var queue = new Queue<char>();
            var result = 0;

            foreach (var character in s)
            {
                while (queue.Contains(character))
                {
                    queue.Dequeue();
                }
                
                queue.Enqueue(character);

                if (queue.Count > result)
                {
                    result = queue.Count;
                }
            }

            return result;
        }

        public static int LengthOfLongestSubstring2(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            
            var substringLengths = new List<int>();

            for (var i = 0; i <= s.Length - 2; i++)
            {
                var characters = new List<char>();
                characters.Add(s[i]);
            
                for (var j = i + 1; j < s.Length; j++)
                {
                    if (characters.Contains(s[j]))
                    {
                        substringLengths.Add(characters.Count);
                        break;
                    }
                    else
                    {
                        characters.Add(s[j]);
                    }
                }
                
                substringLengths.Add(characters.Count);
            }
        
            var result = substringLengths.Max();
            return result;
        }
    }
}
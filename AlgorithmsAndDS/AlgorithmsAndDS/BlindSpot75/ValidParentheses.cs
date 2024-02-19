using System.Linq;

namespace AlgorithmsAndDS.BlindSpot75
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var brackets = new Dictionary<char, char>
            {
                [')'] = '(',
                [']'] = '[',
                ['}'] = '{',
            };

            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                var symbol = s[i];

                var isOpenBracket = brackets.ContainsValue(symbol);

                if (isOpenBracket)
                {
                    stack.Push(symbol);
                }

                var isClosingBracket = brackets.ContainsKey(symbol);

                if (isClosingBracket)
                {
                    if (!stack.Any())
                    {
                        return false;
                    }
                    
                    var lastOpenBracket = stack.Pop();

                    if (lastOpenBracket != brackets[symbol])
                    {
                        return false;
                    }
                }
            }

            var isValid = !stack.Any();

            return isValid;
        }
    }
}
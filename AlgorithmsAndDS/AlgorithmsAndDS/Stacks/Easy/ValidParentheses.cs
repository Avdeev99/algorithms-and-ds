using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Stacks.Easy;

// 20. Valid Parentheses
public class ValidParentheses
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool IsValid(string s)
    {
        var dict = new Dictionary<char, char>
        {
            [')'] = '(',
            [']'] = '[',
            ['}'] = '{',
        };

        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (!dict.ContainsKey(c))
                stack.Push(c);
            else if (!stack.Any() || stack.Pop() != dict[c])
                return false;
        }

        return stack.Count == 0;
    }
    
    // Time complexity: O(n); Space complexity: O(n).
    public bool IsValid2(string s) {
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (c == '(')
                stack.Push(')');
            else if (c == '{')
                stack.Push('}');
            else if (c == '[')
                stack.Push(']');
            else if (stack.Count == 0 || stack.Pop() != c)
                return false;
        }

        return stack.Count == 0;
    }
}
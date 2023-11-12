using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1.Stacks.Medium;

// 2390. Removing Stars From a String
public class RemovingStarsFromString
{
    // StringBuilder stack simulation
    // Time complexity: O(n); Space complexity: O(n).
    public string RemoveStars(string s)
    {
        var stringBuilder = new StringBuilder();

        foreach (var c in s)
        {
            if (c == '*')
                stringBuilder.Length--;
            else
                stringBuilder.Append(c);
        }

        return stringBuilder.ToString();
    }

    // Time complexity: O(n); Space complexity: O(n).
    public string RemoveStars2(string s)
    {
        var stack = new Stack<char>();

        foreach (var character in s)
        {
            if (character == '*')
                stack.Pop();
            else
                stack.Push(character);
        }

        return string.Concat(stack.Reverse());
    }
}
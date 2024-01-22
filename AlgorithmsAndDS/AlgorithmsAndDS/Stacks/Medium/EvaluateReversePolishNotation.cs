using System.Collections.Generic;

namespace ConsoleApp1.Stacks.Medium;

// 150. Evaluate Reverse Polish Notation
public class EvaluateReversePolishNotation
{
    // Time complexity: O(n); Space complexity: O(n).
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        var i = 0;

        foreach (var token in tokens)
        {   
            if (int.TryParse(token, out var digit))
            {
                stack.Push(digit);
                continue;
            }

            var secondDigit = stack.Pop();
            var firstDigit = stack.Pop();
            var result = token switch
            {
                "+" => firstDigit + secondDigit,
                "-" => firstDigit - secondDigit,
                "*" => firstDigit * secondDigit,
                "/" => firstDigit / secondDigit,
            };

            stack.Push(result);
        }

        return stack.Pop();
    }
}
using System.Collections.Generic;

namespace ConsoleApp1.Stacks.Easy;

public class BaseballGame
{
    // Time complexity: O(n); Space complexity: O(n).
    public int CalPoints(string[] operations)
    {
        var stack = new Stack<int>();
        var result = 0;

        foreach (var operation in operations)
        {
            var record = 0;

            if (int.TryParse(operation, out record))
            {
                stack.Push(record);
            }
            else if (operation == "+")
            {
                var last = stack.Pop();
                record = last + stack.Peek();
                stack.Push(last);
                stack.Push(record);
            }
            else if (operation == "D")
            {
                record = stack.Peek() * 2;
                stack.Push(record);
            }
            else if (operation == "C")
            {
                var last = stack.Pop();
                result -= last;
            }

            result += record;
        } 

        return result;   
    }
}
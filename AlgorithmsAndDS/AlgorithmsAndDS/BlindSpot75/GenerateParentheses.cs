using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.BlindSpot75;

public static class GenerateParentheses
{
    public static IList<string> GenerateParenthesis(int n)
    {
        var open = new Stack<string>();
        var close = new Stack<string>();

        for (var i = 0; i < n; i++)
        {
            open.Push("(");
            close.Push(")");
        }

        var str = string.Empty;
        var result = new List<string>();
        
        Generate(open, close, str, result);

        return result;
    }

    private static void Generate(
        Stack<string> open,
        Stack<string> close,
        string str,
        List<string> result)
    {
        if (close.Count < open.Count) return;

        if (!open.Any() && !close.Any())
        {
            result.Add(str);
            return;
        }

        if (open.Any())
        {
            str += open.Pop();
            Generate(open, close, str, result);
            str = str.Substring(0, str.Length - 1);
            open.Push("(");
        }

        if (close.Any())
        {
            str += close.Pop();
            Generate(open, close, str, result);
            str = str.Substring(0, str.Length - 1);
            close.Push(")");
        }
    }
}
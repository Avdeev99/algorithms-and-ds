using System.Text;

namespace AlgorithmsAndDS.Backtracking.Medium;

public class GenerateParentheses
{
    // 22. Generate Parentheses
    public IList<string> GenerateParenthesis(int n)
    {
        var result = new List<string>();
        var curr = new StringBuilder();

        Backtrack(curr, result, n, n);

        return result;
    }

    private void Backtrack(StringBuilder curr, List<string> result, int open, int close)
    {
        if (open == 0 && close == 0)
        {
            result.Add(curr.ToString());
            return;
        }

        if (open > 0)
        {
            curr.Append("(");
            Backtrack(curr, result, open - 1, close);
            curr.Length--;
        }

        if (close > open)
        {
            curr.Append(")");
            Backtrack(curr, result, open, close - 1);
            curr.Length--;
        }
    }
}
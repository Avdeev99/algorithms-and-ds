using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.BlindSpot75;

public static class CombinationSumII
{
    public static IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();

        if (candidates.Length == 0) return result;

        var currComb = new List<int>();

        Backtrack(candidates, target, 0, 0, currComb, result);

        return result;
    }

    public static void Backtrack(
        int[] candidates,
        int target,
        int index,
        int sum,
        List<int> currComb,
        IList<IList<int>> result)
    {
        if (sum == target)
        {
            result.Add(currComb.ToList());
            return;
        }

        if (sum > target) return;

        for (var i = index; i < candidates.Length; i++)
        {
            sum += candidates[i];
            currComb.Add(candidates[i]);

            Backtrack(candidates, target, i+1, sum, currComb, result);

            sum -= candidates[i];
            currComb.RemoveAt(currComb.Count - 1);
        }
    }
}
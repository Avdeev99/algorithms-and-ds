using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1.Backtracking.Medium;

// 39. Combination Sum
public class CombinationSum
{
    // Time complexity: O(n^2).
    public IList<IList<int>> GetCombinationSum(int[] candidates, int target)
    {
        var result = new List<IList<int>>();

        void Backtrack(int index, int currSum, Stack<int> currComb)
        {
            if (index >= candidates.Length || currSum > target)
                return;

            if (currSum == target)
            {
                result.Add(currComb.ToList());
                return;
            }

            currSum += candidates[index];
            currComb.Push(candidates[index]);

            Backtrack(index, currSum, currComb);

            currSum -= candidates[index];
            currComb.Pop();

            Backtrack(index + 1, currSum, currComb);
        }

        Backtrack(0, 0, new Stack<int>());

        return result;
    }
}
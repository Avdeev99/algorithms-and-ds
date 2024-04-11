namespace AlgorithmsAndDS.Backtracking.Medium;

// 78. Subsets
public class Subsets
{
    // Time complexity: O(2^n).
    public IList<IList<int>> GetSubsets(int[] nums)
    {
        var result = new List<IList<int>>
        {
            new List<int>(),
        };

        void Backtrack(int i, List<int> subset)
        {
            if (i >= nums.Length) return;

            subset.Add(nums[i]);
            result.Add(new List<int>(subset));

            Backtrack(i + 1, subset);

            subset.Remove(nums[i]);

            Backtrack(i + 1, subset);
        }

        Backtrack(0, new List<int>());

        return result;
    }
}
namespace AlgorithmsAndDS.Backtracking.Medium;

// 90. Subsets II
public class SubsetsII
{
    // Time complexity: O(2^n).
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        var result = new List<IList<int>> 
        {
            new List<int>(),
        };

        Array.Sort(nums);

        void Dfs(int i, List<int> subset)
        {
            if (i == nums.Length) return;

            if (i != 0 && nums[i] == nums[i - 1] && !subset.Any()) return;

            subset.Add(nums[i]);
            result.Add(new List<int>(subset));

            Dfs(i + 1, subset);

            subset.Remove(nums[i]);

            while (i < nums.Length - 1 && nums[i+1] == nums[i]) i++;

            Dfs(i + 1, subset);
        }

        Dfs(0, new List<int>());

        return result;    
    }
}
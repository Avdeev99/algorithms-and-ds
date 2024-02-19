namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 217. Contains Duplicate
public class ContainsDuplicate
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool Contains(int[] nums)
    {
        var set = new HashSet<int>();

        foreach (var num in nums)
        {
            if (set.Contains(num))
                return true;

            set.Add(num);
        }

        return false;
    }
}
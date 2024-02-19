namespace AlgorithmsAndDS.ArraysAndHashing.Medium;

// 128. Longest Consecutive Sequence
public class LongestConsecutiveSequence
{
    // Time complexity: O(n); Space complexity: O(n).
    public int LongestConsecutive(int[] nums)
    {
        var set = new HashSet<int>(nums);
        var max = 0;

        foreach (var num in nums)
        {
            if (set.Contains(num + 1))
                continue;

            var length = 1;

            while (set.Contains(num - length))
                length++;

            max = Math.Max(max, length);
        }

        return max;    
    }
}
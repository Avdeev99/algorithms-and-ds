using System.Linq;

namespace AlgorithmsAndDS.ArraysAndHashing.Medium;

// 347. Top K Frequent Elements
public class TopKFrequentElements
{
    // Time complexity: O(n); Space complexity: O(n).
    public int[] TopKFrequent(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();
        var freq = new List<int>[nums.Length + 1];

        foreach (var num in nums)
        {
            if (map.ContainsKey(num))
                map[num]++;
            else
                map[num] = 1;
        }

        foreach (var (num, count) in map)
        {
            if (freq[count] == null)
                freq[count] = new List<int>();

            freq[count].Add(num);
        }

        var result = new int[k];
        var resultIndex = 0;

        for (var i = freq.Length - 1; i >= 0 && resultIndex < k; i--)
        {
            if (freq[i] == null) continue;

            for (var j = 0; j < freq[i].Count && resultIndex < k; j++)
            {
                result[resultIndex] = freq[i][j];
                resultIndex++;
            }
        }

        return result;
    }

    // Time complexity: O(nlog(n)); Space complexity: O(n).
    public int[] TopKFrequent2(int[] nums, int k)
    {
        var map = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (map.ContainsKey(num))
                map[num]++;
            else
                map[num] = 1;
        }

        var maxQueue = new PriorityQueue<int, int>(
            map.Select(item => (item.Key, item.Value)),
            Comparer<int>.Create((x,y) => y-x));

        var result = new int[k];

        for (var i = 0; i < k; i++)
        {
            result[i] = maxQueue.Dequeue();
        }

        return result;
    }
}
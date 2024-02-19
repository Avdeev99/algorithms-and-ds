namespace AlgorithmsAndDS.BlindSpot75;

public static class TopKFrequentElements
{
    public static int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();

        foreach (var number in nums)
        {
            if (dict.ContainsKey(number)) dict[number]++;
            else dict[number] = 1;
        }

        var priorityQueue = new PriorityQueue<int, int>(
            Comparer<int>.Create((x, y) => y - x));

        foreach (var item in dict)
        {
            priorityQueue.Enqueue(item.Key, item.Value);
        }
        
        var result = new int[k];
        for (var i = 0; i < k; i++)
        {
            result[i] = priorityQueue.Dequeue();
        }

        return result;
    }
}
namespace AlgorithmsAndDS.PriorityQueue.Medium;

// 621. Task Scheduler
public class TaskScheduler
{
    // Time complexity: O(n); Space complexity: O(n).
    public int LeastInterval(char[] tasks, int n)
    {
        var freqMap = new Dictionary<char, int>();

        foreach (var c in tasks)
        {
            if (freqMap.ContainsKey(c))
                freqMap[c]++;
            else
                freqMap[c] = 1;
        }

        var priorityQueue = new PriorityQueue<(char c, int freq), int>(
            Comparer<int>.Create((x, y) => y - x));

        foreach (var (c, freq) in freqMap)
            priorityQueue.Enqueue((c, freq), freq);

        var result = 0;
        var tempN = n + 1;
        
        while (priorityQueue.Count > 0)
        {
            var temp = new List<(char c, int freq)>();

            while (priorityQueue.Count > 0 && tempN > 0)
            {
                var (c, freq) = priorityQueue.Dequeue();
                result++;
                tempN--;

                if (freq - 1 > 0)
                    temp.Add((c, freq - 1));
            }

            foreach(var item in temp)
                priorityQueue.Enqueue(item, item.freq);

            while (tempN > 0 && priorityQueue.Count > 0)
            {
                result++;
                tempN--;
            }

            tempN = n + 1;
        }

        return result;
    }
}
using System.Linq;

namespace AlgorithmsAndDS.PriorityQueue.Easy;

// 1046. Last Stone Weight
public class LastStoneWeight
{
    // Time complexity: O(nlog(n)); Space complexity: O(n).
    public int GetLastStoneWeight(int[] stones)
    {
        var stonesWithPriority = stones.Select(item => (item, item));
        var priorityQueue = new PriorityQueue<int, int>(
            stonesWithPriority,
            Comparer<int>.Create((x,y) => y-x)
        );

        while (priorityQueue.Count > 1)
        {
            var stone1 = priorityQueue.Dequeue();
            var stone2 = priorityQueue.Dequeue();

            var diff = stone1 - stone2;

            if (diff != 0) priorityQueue.Enqueue(diff, diff);
        }

        return priorityQueue.Count > 0 ? priorityQueue.Peek() : 0;
    }
}
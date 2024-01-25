using System.Collections.Generic;

namespace ConsoleApp1.PriorityQueue.Medium;

// 215. Kth Largest Element in an Array
public class KthLargestElementInAnArray
{
    // Time complexity: O(n + k*log(k)); Space complexity: O(k).
    public int FindKthLargest(int[] nums, int k)
    {
        var priorityQueue = new PriorityQueue<int, int>();

        foreach (var num in nums)
        {
            if (priorityQueue.Count < k)
            {
                priorityQueue.Enqueue(num, num);
            }
            else if (priorityQueue.Peek() < num)
            {
                priorityQueue.EnqueueDequeue(num, num);
            }
        }

        return priorityQueue.Peek();
    }
}
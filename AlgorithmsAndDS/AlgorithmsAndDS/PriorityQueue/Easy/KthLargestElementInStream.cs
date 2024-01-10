using System.Collections.Generic;

namespace ConsoleApp1.PriorityQueue.Easy;

// 703. Kth Largest Element in a Stream
public class KthLargest
{
    private PriorityQueue<int, int> _priorityQueue;
    private int k;

    public KthLargest(int k, int[] nums)
    {
        _priorityQueue = new PriorityQueue<int, int>();
        this.k = k;
        InitQueue(nums);
    }

    // Time complexity: O(log(n));
    public int Add(int val)
    {
        if (_priorityQueue.Count < k)
            _priorityQueue.Enqueue(val, val);
        else if (val > _priorityQueue.Peek())
        {
            _priorityQueue.Dequeue();
            _priorityQueue.Enqueue(val, val);
        }

        return _priorityQueue.Peek();
    }

    // Time complexity: O(nlog(k)); Space complexity: O(k).
    public void InitQueue(int[] nums)
    {
        foreach (var item in nums)
            Add(item);
    }
}
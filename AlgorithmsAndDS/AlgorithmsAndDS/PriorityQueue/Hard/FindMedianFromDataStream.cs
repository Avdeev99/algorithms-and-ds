namespace AlgorithmsAndDS.PriorityQueue.Hard;

// 295. Find Median from Data Stream
public class MedianFinder
{
    private PriorityQueue<int, int> minHeap;
    private PriorityQueue<int, int> maxHeap;

    public MedianFinder()
    {
        minHeap = new PriorityQueue<int, int>();
        maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
    }
    
    // Time complexity: O(log(n)); Space complexity: O(n).
    public void AddNum(int num)
    {
        maxHeap.Enqueue(num, num);

        if ((maxHeap.Count - minHeap.Count > 1) ||
            (minHeap.Count > 0 && maxHeap.Peek() > minHeap.Peek()))
        {
            var item = maxHeap.Dequeue();
            minHeap.Enqueue(item, item);
        }

        if (minHeap.Count - maxHeap.Count > 1)
        {
            var item = minHeap.Dequeue();
            maxHeap.Enqueue(item, item);
        }
    }
    
    // Time complexity: O(1); Space complexity: O(1).
    public double FindMedian()
    {
        if (minHeap.Count != maxHeap.Count)
        {
            return minHeap.Count > maxHeap.Count
                ? minHeap.Peek()
                : maxHeap.Peek();
        }

        double median = (maxHeap.Peek() + minHeap.Peek()) / 2.0;

        return median;
    }
}
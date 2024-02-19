namespace AlgorithmsAndDS.BlindSpot75;

public class KthLargest
{
    private PriorityQueue<int, int> priorityQueue;
    private int k;

    public KthLargest(int k, int[] nums)
    {
        priorityQueue = new PriorityQueue<int, int>();
        this.k = k;
        InitQueue(nums);
    }
    
    public int Add(int val)
    {
        if (priorityQueue.Count < k)
        {
            priorityQueue.Enqueue(val, val);
            return priorityQueue.Peek();
        }
        
        if (val > priorityQueue.Peek())
        {
            priorityQueue.Dequeue();
            priorityQueue.Enqueue(val, val);
            return priorityQueue.Peek();
        }

        return priorityQueue.Peek();
    }

    public void InitQueue(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            if (i < k) priorityQueue.Enqueue(nums[i], nums[i]);
            else if (nums[i] > priorityQueue.Peek())
            {
                priorityQueue.EnqueueDequeue(nums[i], nums[i]);
            }
        }
    }
}
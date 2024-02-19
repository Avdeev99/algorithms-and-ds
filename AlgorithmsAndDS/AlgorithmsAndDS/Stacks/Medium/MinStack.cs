using System.Linq;

namespace AlgorithmsAndDS.Stacks.Medium;

// 155. Min Stack
public class MinStack
{
    private readonly Stack<(int, int)> stack = new();

    // Time complexity: O(1); Space complexity: O(1).
    public void Push(int val)
    {
        if (!stack.Any())
        {
            stack.Push((val, val));
            return;
        }

        var (_, lastMin) = stack.Peek();
        var min = Math.Min(val, lastMin);
        stack.Push((val, min));
    }
    
    // Time complexity: O(1); Space complexity: O(1).
    public void Pop()
    {
        stack.Pop();
    }
    
    // Time complexity: O(1); Space complexity: O(1).
    public int Top()
    {
        var (val, _) = stack.Peek();

        return val;
    }
    
    // Time complexity: O(1); Space complexity: O(1).
    public int GetMin()
    {
        var (_, min) = stack.Peek();

        return min;   
    }
}
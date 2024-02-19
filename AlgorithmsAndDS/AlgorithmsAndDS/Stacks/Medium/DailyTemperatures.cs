using System.Linq;

namespace AlgorithmsAndDS.Stacks.Medium;

// 739. Daily Temperatures
public class DailyTemperatures
{
    // Time complexity: O(n); Space complexity: O(n).
    public int[] GetDailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];
        var stack = new Stack<(int val, int index)>();
        var j = 0;

        for (var i = 0; i < temperatures.Length; i++)
        {
            while (stack.Any() && temperatures[i] > stack.Peek().val)
            {
                var (val, index) = stack.Pop();
                result[index] = i - index;
            }

            stack.Push((temperatures[i], i));
        }

        return result;   
    }
}
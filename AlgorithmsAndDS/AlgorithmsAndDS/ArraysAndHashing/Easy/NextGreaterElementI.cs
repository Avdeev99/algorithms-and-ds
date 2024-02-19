using System.Linq;

namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 496. Next Greater Element I
public class NextGreaterElementI
{
    // Time complexity: O(n+m); Space complexity: O(n+m)
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        var dict = nums1
            .Select((value, index) => new { Index = index, Value = value })
            .ToDictionary(item => item.Value, item => item.Index);

        var result = Enumerable.Repeat(-1, nums1.Length).ToArray();
        var stack = new Stack<int>();

        foreach (var num in nums2)
        {
            while(stack.Any() && num > stack.Peek())
            {
                var val = stack.Pop();
                var index = dict[val];
                result[index] = num;
            }

            if (dict.ContainsKey(num))
                stack.Push(num);
        }

        return result;
    }
}
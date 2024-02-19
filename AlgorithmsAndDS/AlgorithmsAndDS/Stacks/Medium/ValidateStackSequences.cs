using System.Linq;

namespace AlgorithmsAndDS.Stacks.Medium;

// 946. Validate Stack Sequences
public class ValidateStackSequences
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool ValidateStack(int[] pushed, int[] popped)
    {
        var stack = new Stack<int>();
        var j = 0;

        for (var i = 0; i < pushed.Length; i++)
        {
            stack.Push(pushed[i]);

            while (stack.Any() && j < popped.Length && stack.Peek() == popped[j])
            {
                stack.Pop();
                j++;
            }
        }

        return stack.Count == 0;
    }
}
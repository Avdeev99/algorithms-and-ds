namespace AlgorithmsAndDS.BlindSpot75;

public static class DailyTemperatures
{
    public static int[] Process(int[] temperatures) {
        var stack = new Stack<(int val, int index)>();
        var result = new int[temperatures.Length];

        for (var i = 1; i < temperatures.Length; i++)
        {
            while (stack.Count > 0)
            {
                var top = stack.Peek();
                if (top.val >= temperatures[i]) break;

                result[top.index] = i - top.index;
                stack.Pop();
            }
            
            if (temperatures[i] > temperatures[i - 1]) result[i - 1] = 1;
            else stack.Push((temperatures[i-1], i-1));
        }

        return result;
    }
}
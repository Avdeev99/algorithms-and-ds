namespace AlgorithmsAndDS.BitManipulation.Easy;

// 338. Counting Bits
public class CountingBits
{
    // Time complexity: O(n); Space complexity: O(1).
    public int[] CountBits(int n)
    {
        var result = new int[n + 1];
        var offset = 1;

        for (var i = 1; i <= n; i++)
        {
            if (offset * 2 == i)
                offset *= 2;
            
            result[i] = 1 + result[i - offset];
        }

        return result;
    }
    
    // Time complexity: O(n*log(n)); Space complexity: O(1).
    public int[] CountBits2(int n)
    {
        var result = new int[n + 1];

        for (var i = 1; i <= n; i++)
        {
            var count = 0;
            var num = i;

            while (num != 0)
            {
                count += num % 2;
                num /= 2;
            }
            
            result[i] = count;
        }

        return result;
    }
}
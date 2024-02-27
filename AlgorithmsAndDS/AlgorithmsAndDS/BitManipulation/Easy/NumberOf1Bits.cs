namespace AlgorithmsAndDS.BitManipulation.Easy;

// 191. Number of 1 Bits
public class NumberOf1Bits
{
    // Time complexity: O(k), k - number of 1 bits; Space complexity: O(1).
    public int HammingWeight(uint n)
    {
        var count = 0;

        while (n != 0)
        {
            n = n & (n - 1);
            count++;
        }

        return count;
    }
}
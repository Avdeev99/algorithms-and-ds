namespace AlgorithmsAndDS.BitManipulation.Medium;

// 371. Sum of Two Integers
public class SumOfTwoIntegers
{
    // Time complexity: O(1); Space complexity: O(1).
    public int GetSum(int a, int b)
    {
        while (b != 0)
        {
            var xor = a ^ b;
            b = (a & b) << 1;
            a = xor;
        }

        return a;        
    }
}
namespace AlgorithmsAndDS.BitManipulation.Easy;

// 190. Reverse Bits
public class ReverseBits
{
    // Time complexity: O(1); Space complexity: O(1).
    public uint reverseBits(uint n)
    {
        uint result = 0;

        for (var i = 0; i < 32; i++)
        {
            uint bit = (n >> i) & 1;
            result = result | (bit << 31 - i);
        }

        return result;
    }
}
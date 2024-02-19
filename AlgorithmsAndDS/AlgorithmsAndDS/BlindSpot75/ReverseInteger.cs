using System.Text;

namespace AlgorithmsAndDS.BlindSpot75;

public static class ReverseInteger
{
    public static int Reverse(int x) {
        var result = new StringBuilder();

        while (x != 0)
        {
            result.Append(x % 10);
            x /= 10;
        }

        return Convert.ToInt32(result.ToString());
    }
}
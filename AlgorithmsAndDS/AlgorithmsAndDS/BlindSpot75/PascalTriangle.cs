using System.Collections.Generic;

namespace ConsoleApp1.BlindSpot75;

public static class PascalTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var result = new int[5][];
        result[0] = new[] { 1 };

        if (numRows == 1)
        {
            return result;
        }
        
        result[1] = new[] { 1, 1 };
        
        if (numRows == 2)
        {
            return result;
        }

        for (var i = 2; i < numRows; i++)
        {
            var itemsCount = i + 1;
            result[i] = new int[itemsCount];
            result[i][0] = 1;
            result[i][i] = 1;

            for (var j = 1; j < i; j++)
            {
                result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
            }
        }

        return result;
    }
}
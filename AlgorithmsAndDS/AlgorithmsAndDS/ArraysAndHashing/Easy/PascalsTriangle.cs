namespace AlgorithmsAndDS.ArraysAndHashing.Easy;

// 118. Pascal's Triangle
public class PascalsTriangle
{
    // Time complexity: O(n^2); Space complexity: O(n^2).

    public IList<IList<int>> Generate(int numRows)
    {
        var result = new int[numRows][];

        for (var i = 0; i < numRows; i++)
        {
            result[i] = new int[i + 1];
            result[i][0] = result[i][i] = 1;

            for (var j = 1; j < i; j++)
            {
                result[i][j] = result[i - 1][j - 1] + result[i - 1][j];
            }
        }

        return result;
    }
}
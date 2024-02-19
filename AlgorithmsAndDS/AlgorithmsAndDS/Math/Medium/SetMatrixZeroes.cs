namespace AlgorithmsAndDS.Math.Medium;

// 73. Set Matrix Zeroes
public class SetMatrixZeroes
{
    // Time complexity: O(m*n); Space complexity: O(1).
    public void SetZeroes(int[][] matrix)
    {
        var col0 = false;
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        for (var i = 0; i < rows; i++)
        {
            if (matrix[i][0] == 0) col0 = true;

            for (var j = 1; j < cols; j++)
            {
                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }

        for (var i = rows - 1; i >= 0; i--)
        {
            for (var j = cols - 1; j >= 1; j--)
            {
                if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    matrix[i][j] = 0;
            }

            if (col0) matrix[i][0] = 0;
        }
    }
}
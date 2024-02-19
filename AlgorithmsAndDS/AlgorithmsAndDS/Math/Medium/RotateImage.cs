namespace AlgorithmsAndDS.Math.Medium;

// 48. Rotate Image
public class RotateImage
{
    // Time complexity: O(n^2); Space complexity: O(1).
    public void Rotate(int[][] matrix)
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;

        for (var i = 0; i < rows - 1; i++)
        {
            for (var j = i; j < cols - 1 - i; j++)
            {
                var r = i;
                var c = j;
                var counter = 0;

                while (counter < 4)
                {
                    var newRow = c;
                    var newCol = rows - r - 1;

                    (matrix[i][j], matrix[newRow][newCol]) = (matrix[newRow][newCol], matrix[i][j]);

                    r = newRow;
                    c = newCol;
                    counter++;
                }
            }
        }
    }
}
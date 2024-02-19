namespace AlgorithmsAndDS.Math.Medium;

// 54. Spiral Matrix
public class SpiralMatrix
{
    // Time complexity: O(n*m); Space complexity: O(1).
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var result = new List<int>();

        var top = 0;
        var bottom = matrix.Length - 1;
        var left = 0;
        var right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            for (var i = left; i <= right; i++)
                result.Add(matrix[top][i]);

            if (top == bottom) return result;

            for (var i = top + 1; i <= bottom ; i++)
                result.Add(matrix[i][right]);

            if (left == right) return result;

            for (var i = right - 1; i >= left ; i--)
                result.Add(matrix[bottom][i]);

            for (var i = bottom - 1; i > top ; i--)
                result.Add(matrix[i][left]);

            left++;
            right--;
            top++;
            bottom--;
        }

        return result;
    }
}
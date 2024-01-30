using System.Collections.Generic;

namespace ConsoleApp1.Graphs.Medium;

// 417. Pacific Atlantic Water Flow
public class PacificAtlanticWaterFlow
{
    // Time complexity: O(n*m); Space complexity: O(n*m).
    public IList<IList<int>> PacificAtlantic(int[][] heights)
    {
        var rows = heights.Length;
        var cols = heights[0].Length;
        var pacificVisited = new bool[rows, cols];
        var atlanticVisited = new bool[rows, cols];

        for (var row = 0; row < rows; row++)
        {
            Dfs(heights, row, 0, heights[row][0], pacificVisited);
            Dfs(heights, row, cols-1, heights[row][cols-1], atlanticVisited);
        }

        for (var col = 0; col < cols; col++)
        {
            Dfs(heights, 0, col, heights[0][col], pacificVisited);
            Dfs(heights, rows-1, col, heights[rows-1][col], atlanticVisited);
        }

        var result = new List<IList<int>>();

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (pacificVisited[i, j] && atlanticVisited[i, j])
                    result.Add(new[] { i, j });
            }
        }

        return result;
    }

    private void Dfs(int[][] heights, int r, int c, int prevVal, bool[,] visited)
    {
        var rows = heights.Length;
        var cols = heights[0].Length;

        if (r < 0 || c < 0 || r >= rows || c >= cols ||
            heights[r][c] < prevVal || visited[r, c])
            return;

        visited[r, c] = true;

        Dfs(heights, r-1, c, heights[r][c], visited);
        Dfs(heights, r+1, c, heights[r][c], visited);
        Dfs(heights, r, c-1, heights[r][c], visited);
        Dfs(heights, r, c+1, heights[r][c], visited);
    }
}
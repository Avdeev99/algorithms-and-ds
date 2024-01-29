namespace ConsoleApp1.Graphs.Medium;

// 200. Number of Islands
public class NumberOfIslands
{
    // Time complexity: O(n*m); Space complexity: O(n*m).
    public int NumIslands(char[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;

        void Dfs(int row, int col, bool[,] visited)
        {
            if (row < 0 || row >= rows ||
                col < 0 || col >= cols ||
                grid[row][col] == '0' ||
                visited[row, col])
            {
                return;
            }

            visited[row, col] = true;

            Dfs(row + 1, col, visited);
            Dfs(row - 1, col, visited);
            Dfs(row, col + 1, visited);
            Dfs(row, col - 1, visited);
        }

        var visited = new bool[rows, cols];
        var result = 0;

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (grid[i][j] == '0' || visited[i, j])
                    continue;

                Dfs(i, j, visited);
                result++;
            }
        }

        return result;
    }
}
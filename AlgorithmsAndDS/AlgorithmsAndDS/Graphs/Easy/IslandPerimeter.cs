namespace AlgorithmsAndDS.Graphs.Easy;

public class IslandPerimeter
{
    // Time complexity: O(n*m); Space complexity: O(n*m).
    public int GetIslandPerimeter(int[][] grid)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;
        var visited = new int[rows, cols];

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (grid[i][j] == 1)
                    return Dfs(grid, i, j, visited);
            }
        }

        return 0;
    }

    private int Dfs(int[][] grid, int i, int j, int[,] visited)
    {
        var rows = grid.Length;
        var cols = grid[0].Length;

        if (i < 0 || i >= rows || j < 0 || j >= cols || grid[i][j] == 0)
            return 1;

        if (visited[i, j] == 1)
            return 0;

        visited[i, j] = 1;

        var result = Dfs(grid, i-1, j, visited);
        result += Dfs(grid, i+1, j, visited);
        result += Dfs(grid, i, j-1, visited);
        result += Dfs(grid, i, j+1, visited);

        return result;
    }
}
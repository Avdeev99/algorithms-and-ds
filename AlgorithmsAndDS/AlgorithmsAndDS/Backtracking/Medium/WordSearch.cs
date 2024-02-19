namespace AlgorithmsAndDS.Backtracking.Medium;

// 79. Word Search
public class WordSearch
{
    // Time complexity: OO(n * m * 4^n)
    public bool Exist(char[][] board, string word)
    {
        var rows = board.Length;
        var cols = board[0].Length;

        bool Dfs(int row, int col, int index, bool[,] visited)
        {
            if (index == word.Length)
                return true;

            if (row < 0 || row >= rows ||
                col < 0 || col >= cols ||
                word[index] != board[row][col] ||
                visited[row, col])
            {
                return false; 
            }

            visited[row, col] = true;

            var result = Dfs(row + 1, col, index + 1, visited) ||
                         Dfs(row - 1, col, index + 1, visited) ||
                         Dfs(row, col + 1, index + 1, visited) ||
                         Dfs(row, col - 1, index + 1, visited);

            visited[row, col] = false;

            return result;
        }

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                if (board[i][j] != word[0]) continue;

                var visited = new bool[rows, cols];

                var isFound = Dfs(i, j, 0, visited);

                if (isFound) return true;
            }
        }
        
        return false;
    }
}
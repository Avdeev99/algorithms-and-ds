namespace AlgorithmsAndDS.ArraysAndHashing.Medium;

// 36. Valid Sudoku
public class ValidSudoku
{
    // Time complexity: O(n^2); Space complexity: O(n^2).
    public bool IsValidSudoku(char[][] board)
    {
        var rows = board.Length;
        var cols = board[0].Length;
        var rowItems = new Dictionary<int, HashSet<int>>();
        var colItems = new Dictionary<int, HashSet<int>>();
        var subBoards = new Dictionary<(int, int), HashSet<int>>();
        
        for (var i = 0; i < rows; i++)
        {
            rowItems[i] = new HashSet<int>();   

            for (var j = 0; j < cols; j++)
            {
                if (!colItems.ContainsKey(j))
                    colItems[j] = new HashSet<int>();

                if (!subBoards.ContainsKey((i/3, j/3)))
                    subBoards[(i/3, j/3)] = new HashSet<int>();

                var item = board[i][j];

                if (item == '.')
                    continue;

                var alreadyContains = rowItems[i].Contains(item) || colItems[j].Contains(item) ||
                                      subBoards[(i/3, j/3)].Contains(item);

                if (alreadyContains)
                    return false;

                rowItems[i].Add(item);
                colItems[j].Add(item);
                subBoards[(i/3, j/3)].Add(item);
            }
        }

        return true;
    }
}
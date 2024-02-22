using System.Text;

namespace AlgorithmsAndDS.Tries.Hard;

// 212. Word Search II
public class WordSearchII
{
    public IList<string> FindWords(char[][] board, string[] words)
    {
        var foundWords = new HashSet<string>();
        var trie = new Trie();

        foreach (var word in words)
        {
            trie.Insert(word);
        }

        var rows = board.Length;
        var cols = board[0].Length;

        void Dfs(int i, int j, TrieNode currNode, bool[,] visited, StringBuilder currStr)
        {
            if (i < 0 || i >= rows ||
                j < 0 || j >= cols ||
                visited[i, j])
            {
                return;
            }

            var childExists = currNode.Children.TryGetValue(board[i][j], out var child);

            if (!childExists)
                return;

            currStr.Append(board[i][j]);

            if (child.IsWord)
            {
                foundWords.Add(currStr.ToString());
            }

            visited[i, j] = true;

            Dfs(i + 1, j, child, visited, currStr);
            Dfs(i - 1, j, child, visited, currStr);
            Dfs(i, j + 1, child, visited, currStr);
            Dfs(i, j - 1, child, visited, currStr);

            visited[i, j] = false;
            currStr.Length--;
        }

        for (var i = 0; i < rows; i++)
        {
            for (var j = 0; j < cols; j++)
            {
                var visited = new bool[rows, cols];
                Dfs(i, j, trie.Root, visited, new StringBuilder());
            }
        }

        return foundWords.ToList();
    }
}
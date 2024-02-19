namespace AlgorithmsAndDS.Tries.Medium;

// 211. Design Add and Search Words Data Structure
public class DesignAddAndSearchWordsDataStructure
{
    public TrieNode Root { get; set; }

    public DesignAddAndSearchWordsDataStructure()
    {
        Root = new TrieNode();
    }
    
    public void AddWord(string word)
    {
        var curr = Root;

        foreach (var c in word)
        {
            var childExists = curr.Children.TryGetValue(c, out var child);

            if (childExists)
                curr = child;
            else
            {
                var newChild = new TrieNode();
                curr.Children[c] = newChild;
                curr = newChild;
            }
        }

        curr.IsWord = true;
    }

    public bool Search(string word)
    {
        bool Dfs(int i, TrieNode curr)
        {
            if (i == word.Length)
                return curr.IsWord;

            if (word[i] == '.')
            {
                foreach (var (_, node) in curr.Children)
                {
                    var searchResult = Dfs(i + 1, node);

                    if (searchResult) return true;
                }

                return false;
            }

            if (!curr.Children.TryGetValue(word[i], out var child))
                return false;

            return Dfs(i + 1, child);
        }

        return Dfs(0, Root);
    }
}
namespace AlgorithmsAndDS.Tries;

// 208. Implement Trie (Prefix Tree)
public class Trie
{
    public Trie()
    {
        Root = new TrieNode();
    }
    
    public TrieNode Root { get; set; }
    
    public void Insert(string word)
    {
        var currentNode = Root;

        foreach (var character in word)
        {
            if (!currentNode.Children.ContainsKey(character))
            {
                currentNode.Children[character] = new TrieNode();
            }

            currentNode = currentNode.Children[character];
        }

        currentNode.IsWord = true;
    }
    
    public bool Search(string word)
    {
        var currentNode = Root;

        foreach (var character in word)
        {
            if (!currentNode.Children.ContainsKey(character))
            {
                return false;
            }

            currentNode = currentNode.Children[character];
        }

        return currentNode.IsWord;
    }
    
    public bool StartsWith(string prefix)
    {
        var currentNode = Root;

        foreach (var character in prefix)
        {
            if (!currentNode.Children.ContainsKey(character))
            {
                return false;
            }

            currentNode = currentNode.Children[character];
        }

        return true;
    }
}
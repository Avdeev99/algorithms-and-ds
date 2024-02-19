namespace AlgorithmsAndDS.Tries;

public class TrieNode
{
    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
    }

    public bool IsWord { get; set; }

    public Dictionary<char, TrieNode> Children { get; set; }
}
using System.Text;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

public class ConstructStringFromBinaryTree
{
    // Time complexity: O(n); Space complexity: O(n).
    public string Tree2str(TreeNode root)
    {
        var result = new StringBuilder();

        Dfs(root, result);

        return result.ToString();
    }

    private void Dfs(TreeNode node, StringBuilder strBuilder)
    {
        if (node == null)
            return; 

        strBuilder.Append(node.val);

        if (node.left == null && node.right == null)
            return;

        strBuilder.Append("(");

        Dfs(node.left, strBuilder);
        
        strBuilder.Append(")");

        if (node.right == null)
            return;

        strBuilder.Append("(");
        
        Dfs(node.right, strBuilder);
        
        strBuilder.Append(")");
    }
}
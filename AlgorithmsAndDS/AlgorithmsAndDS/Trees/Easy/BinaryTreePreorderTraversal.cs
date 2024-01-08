using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

// 144. Binary Tree Preorder Traversal
public class BinaryTreePreorderTraversal
{
    // Time complexity: O(n); Space complexity: O(n).
    public IList<int> PreorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var curr = root;

        while (curr != null || stack.Any())
        {
            if (curr != null)
            {
                result.Add(curr.val);
                stack.Push(curr.right);
                curr = curr.left;
            }
            else
            {
                curr = stack.Pop();
            }
        }

        return result;   
    }

    // Time complexity: O(n); Space complexity: O(n).
    public IList<int> PreorderTraversalRecursive(TreeNode root)
    {
        var result = new List<int>();

        if (root == null)
            return result;

        Dfs(root, result);

        return result;   
    }

    private void Dfs(TreeNode node, List<int> result)
    {
        result.Add(node.val);

        if (node.left != null)
            Dfs(node.left, result);

        if (node.right != null)
            Dfs(node.right, result);
    }
}
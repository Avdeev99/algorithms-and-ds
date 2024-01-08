using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

// 94. Binary Tree Inorder Traversal
public class BinaryTreeInorderTraversal
{
    // Time complexity: O(n); Space complexity: O(n).
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        var stack = new Stack<TreeNode>();
        var curr = root;

        while (curr != null || stack.Any())
        {
            if (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            else
            {
                var prevNode = stack.Pop();
                result.Add(prevNode.val);
                curr = prevNode.right;
            }
        }

        return result; 
    }
    
    // Time complexity: O(n); Space complexity: O(n).
    public IList<int> InorderTraversalRecursively(TreeNode root)
    {
        var result = new List<int>();

        if (root == null)
            return result;

        Dfs(root, result);

        return result;   
    }

    private void Dfs(TreeNode node, List<int> result)
    {
        if (node.left != null)
            Dfs(node.left, result);
        
        result.Add(node.val);

        if (node.right != null)
            Dfs(node.right, result);
    }
}
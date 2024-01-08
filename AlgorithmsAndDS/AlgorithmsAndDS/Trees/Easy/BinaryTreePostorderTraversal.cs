using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

// 145. Binary Tree Postorder Traversal
public class BinaryTreePostorderTraversal
{
    // Time complexity: O(n); Space complexity: O(n).
    public IList<int> PostorderTraversal(TreeNode root)
    {
        var result = new List<int>();

        if (root == null)
            return result;
        
        var stack = new Stack<(TreeNode node, bool visited)>();
        stack.Push((root, false));

        while (stack.Any())
        {
            var (curr, visited) = stack.Pop();

            if (curr == null)
                continue;
            
            if (visited)
                result.Add(curr.val);
            else
            {
                stack.Push((curr, true));
                stack.Push((curr.right, false));
                stack.Push((curr.left, false));
            }
        }

        return result;
    }
    
    // Time complexity: O(n); Space complexity: O(n).
    public IList<int> PostorderTraversalRecursively(TreeNode root)
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

        if (node.right != null)
            Dfs(node.right, result);

        result.Add(node.val);
    }
}
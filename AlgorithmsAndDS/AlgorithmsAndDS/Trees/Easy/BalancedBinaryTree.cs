using System;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

// 110. Balanced Binary Tree
public class BalancedBinaryTree
{
    private bool isBalanced = true;

    // Time complexity: O(n); Space complexity: O(n).
    public bool IsBalanced(TreeNode root)
    {
        if (root == null) return true;

        Dfs(root);

        return isBalanced;
    }

    private int Dfs(TreeNode node)
    {
        if (node == null) return 0;

        var leftDepth = Dfs(node.left);
        var rightDepth = Dfs(node.right);

        var diff = Math.Abs(leftDepth - rightDepth);

        if (diff > 1)
            isBalanced = false;
        
        return 1 + Math.Max(leftDepth, rightDepth);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

// 104. Maximum Depth of Binary Tree
public class MaximumDepthOfBinaryTree
{
    // Time complexity: O(n); Space complexity: O(n).
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }
    
    // DFS
    // Time complexity: O(n); Space complexity: O(n).
    public int MaxDepthDFS(TreeNode root)
    {
        var max = 0;
        var stack = new Stack<(TreeNode, int)>();
        stack.Push((root, 1));

        while (stack.Any())
        {
            var (node, depth) = stack.Pop();

            if (node == null) continue;

            max = Math.Max(max, depth);

            stack.Push((node.left, depth + 1));
            stack.Push((node.right, depth + 1));
        }
        return max;
    }
    
    // BFS
    // Time complexity: O(n); Space complexity: O(n).
    public int MaxDepthBFS(TreeNode root)
    {
        if (root == null) return 0;

        var level = 0;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var levelLength = queue.Count;

            for (var i = 0; i < levelLength; i++)
            {
                var node = queue.Dequeue();

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            level++;
        }

        return level;
    }
}
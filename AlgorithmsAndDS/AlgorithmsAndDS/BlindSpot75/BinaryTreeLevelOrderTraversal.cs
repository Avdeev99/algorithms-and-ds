using System.Collections.Generic;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.BlindSpot75;

public static class BinaryTreeLevelOrderTraversal
{
    public static IList<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null) return new int[][] {};

        var result = new List<IList<int>>();

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var level = new List<int>();
            var levelCount = queue.Count;

            for (var i = 0; i < levelCount; i++)
            {
                var node = queue.Dequeue();
                if (node?.left != null) queue.Enqueue(node.left);
                if (node?.right != null) queue.Enqueue(node.right);
                if (node?.val != null) level.Add(node.val);
            }

            result.Add(level);
        }

        return result;
    }
}
using System.Linq;
using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Medium;

// 102. Binary Tree Level Order Traversal
public class BinaryTreeLevelOrderTraversal
{
    // Time complexity: O(n); Space complexity: O(n).
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();

        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var levelCount = queue.Count;
            var level = new List<int>();

            for (var i = 0; i < levelCount; i++)
            {
                var node = queue.Dequeue();

                level.Add(node.val);

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            result.Add(level);
        }

        return result;
    }
}
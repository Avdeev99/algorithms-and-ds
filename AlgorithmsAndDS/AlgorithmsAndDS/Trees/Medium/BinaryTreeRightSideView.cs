using System.Linq;
using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Medium;

// 199. Binary Tree Right Side View
public class BinaryTreeRightSideView
{
    // Time complexity: O(n); Space complexity: O(n).
    public IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();

        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var levelCount = queue.Count;

            for (var i = 0; i < levelCount; i++)
            {
                var node = queue.Dequeue();

                if (i == 0)
                    result.Add(node.val);

                if (node.right != null)
                    queue.Enqueue(node.right);

                if (node.left != null)
                    queue.Enqueue(node.left);
            }
        }

        return result;   
    }
}
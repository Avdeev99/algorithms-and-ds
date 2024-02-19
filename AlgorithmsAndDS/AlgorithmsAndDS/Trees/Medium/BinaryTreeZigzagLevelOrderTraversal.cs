using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Medium;

// 103. Binary Tree Zigzag Level Order Traversal
public class BinaryTreeZigzagLevelOrderTraversal
{
    // Time complexity: O(n); Space complexity: O(n).
    public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
    {
        var result = new List<IList<int>>();

        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        var levelNumber = 0;

        while (queue.Count > 0)
        {
            var levelCount = queue.Count;
            var level = new int[levelCount];
            var ascOrder = levelNumber % 2 == 0;
            var index = ascOrder ? 0 : levelCount-1;

            for (var i = 0; i < levelCount; i++)
            {
                var node = queue.Dequeue();
                
                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
                
                level[index] = node.val;

                if (ascOrder) index++;
                else index --;
            }

            result.Add(level);
            levelNumber++;
        }

       
        return result;
    }
}
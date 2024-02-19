using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Easy;

// 101. Symmetric Tree
public class SymmetricTree
{
    // Time complexity: O(n); Space complexity: O(h) - height of the tree.
    public bool IsSymmetric(TreeNode root)
    {
        if (root == null) return true;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root.left);
        queue.Enqueue(root.right);

        while(queue.Count > 0)
        {
            var left = queue.Dequeue();
            var right = queue.Dequeue();

            if(left == null && right == null)
                continue;

            if(left == null || right == null || left.val != right.val )
                return false;

            queue.Enqueue(left.left);
            queue.Enqueue(right.right);
            queue.Enqueue(left.right);
            queue.Enqueue(right.left);
        }

        return true;
    }
    
    // Time complexity: O(n); Space complexity: O(h) - height of the tree.
    public bool IsSymmetric2(TreeNode root)
    {
        if (root == null)
            return true;

        return IsMirror(root.left, root.right);
    }
    
    private bool IsMirror(TreeNode node1, TreeNode node2)
    {
        if (node1 == null && node2 == null)
            return true;

        if (node1 == null || node2 == null)
            return false;

        return node1.val == node2.val && IsMirror(node1.left, node2.right) && IsMirror(node1.right, node2.left);
    }
}
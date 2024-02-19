using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.BlindSpot75;

public static class SymmetricTree
{
    public static bool IsSymmetric(TreeNode root) {
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
}
using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Easy;

// 100. Same Tree
public class SameTree
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null)
            return true;

        if (p == null || q== null)
            return false;

        return p.val == q.val &&
               IsSameTree(p.left, q.left) &&
               IsSameTree(p.right, q.right);
    }
}
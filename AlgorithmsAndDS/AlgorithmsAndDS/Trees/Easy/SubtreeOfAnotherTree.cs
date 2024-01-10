using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

// 572. Subtree of Another Tree
public class SubtreeOfAnotherTree
{
    // Time complexity: O(nm); Space complexity: O(nm).
    public bool IsSubtree(TreeNode root, TreeNode subRoot)
    {
        if (root == null || subRoot == null) return false;
        var isSame = false;

        if (root.val == subRoot.val)
        {
            isSame = IsSameTree(root, subRoot);
        }

        return isSame || IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot);
    }

    private bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null || q == null) return p == q;

        return p.val == q.val
               && IsSameTree(p.left, q.left)
               && IsSameTree(p.right, q. right);
    }
}
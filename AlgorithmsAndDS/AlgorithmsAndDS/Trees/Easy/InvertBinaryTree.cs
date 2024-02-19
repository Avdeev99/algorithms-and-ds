using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Easy;

// 226. Invert Binary Tree
public class InvertBinaryTree
{
    // Time complexity: O(n); Space complexity: O(n).
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        (root.left, root.right) = (root.right, root.left);

        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}
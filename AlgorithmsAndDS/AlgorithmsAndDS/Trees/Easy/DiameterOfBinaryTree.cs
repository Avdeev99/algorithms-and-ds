using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Easy;

// 543. Diameter of Binary Tree
public class DiameterOfBinaryTree
{
    private int _max = 0;

    // Time complexity: O(n); Space complexity: O(n).
    public int Diameter(TreeNode root)
    {
        if (root == null) return 0;

        Dfs(root);

        return _max;
    }

    private int Dfs(TreeNode root)
    {
        if (root == null) return 0;

        var left = Dfs(root.left);
        var right = Dfs(root.right);

        _max = Math.Max(_max, left + right);

        return Math.Max(left, right) + 1;
    }
}
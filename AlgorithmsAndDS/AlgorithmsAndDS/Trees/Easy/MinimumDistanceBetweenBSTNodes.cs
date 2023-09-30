using System;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

public class MinimumDistanceBetweenBSTNodes
{
    private int minDiff = int.MaxValue;
    private TreeNode prevNode = null;

    // Time complexity: O(n); Space complexity: O(n).
    public int MinDiffInBST(TreeNode root)
    {
        if (root.left != null)
            MinDiffInBST(root.left);

        if (prevNode != null)
            minDiff = Math.Min(minDiff, root.val - prevNode.val);

        prevNode = root;

        if (root.right != null)
            MinDiffInBST(root.right);

        return minDiff;
    }
}
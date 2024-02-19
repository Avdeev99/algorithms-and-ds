using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Easy;

public class MergeTwoBinaryTrees
{
    // Time complexity: O(n); Space complexity: O(n).
    public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
    {
        if (root1 == null && root2 == null)
            return null;

        if (root1 == null)
            return root2;
        
        if (root2 == null)
            return root1;

        var node = new TreeNode(root1.val + root2.val);
        node.left = MergeTrees(root1.left, root2.left);
        node.right = MergeTrees(root1.right, root2.right);

        return node;
    }
}
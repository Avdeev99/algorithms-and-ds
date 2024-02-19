using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.BlindSpot75;

public static class MaximumDepthOfBinaryTree
{
    private static int TreeMaxDepth = 1;
    
    
    public static int MaxDepth1(TreeNode root)
    {
        if (root == null) return 0;
        
        var maxDepth = Math.Max(MaxDepth1(root.left), MaxDepth1(root.right)) + 1;
        
        return maxDepth;   
    }
    
    public static int MaxDepth(TreeNode root) {
        if (root == null) return 0;
        var counter = 0;

        return Traverse(root, counter);
    }

    public static int Traverse(TreeNode node, int counter)
    {
        counter++;
        
        if (node.left != null)
        {
            Traverse(node.left, counter);
        }
        else
        {
            TreeMaxDepth = Math.Max(counter, TreeMaxDepth);
        }

        if (node.right != null)
        {
            Traverse(node.right, counter);
        }
        else
        {
            TreeMaxDepth = Math.Max(counter, TreeMaxDepth);
        }

        return TreeMaxDepth;
    }
}
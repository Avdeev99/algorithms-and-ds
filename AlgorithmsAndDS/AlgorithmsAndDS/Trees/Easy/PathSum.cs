using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

public class PathSum
{
    // Time complexity: O(n); Space complexity: O(n).
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return Dfs(root, targetSum, 0);
    }

    private bool Dfs(TreeNode node, int targetSum, int currSum)
    {
        if (node == null)
            return false;

        currSum += node.val;

        if (node.left == null && node.right == null)
            return targetSum == currSum;

        return Dfs(node.left, targetSum, currSum) || Dfs(node.right, targetSum, currSum);
    }
}
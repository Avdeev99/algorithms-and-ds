using System.Linq;
using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Easy;

// 112. Path Sum
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
    
    // Time complexity: O(n); Space complexity: O(n).
    public bool HasPathSumIterative(TreeNode root, int targetSum)
    {
        if (root == null) return false;

        var stack = new Stack<(TreeNode, int)>();
        stack.Push((root, targetSum - root.val));

        while (stack.Any())
        {
            var (node, leftSum) = stack.Pop();

            if (leftSum == 0 && node.left == null && node.right == null)
                return true;
            if (node.right != null)
                stack.Push((node.right, leftSum - node.right.val));
            if (node.left != null)
                stack.Push((node.left, leftSum - node.left.val));
        }

        return false;
    }
}
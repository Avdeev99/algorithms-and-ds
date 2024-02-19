using System.Linq;
using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Trees.Easy;

// 108. Convert Sorted Array to Binary Search Tree
public class ConvertSortedArrayToBinarySearchTree
{
    // Time complexity: O(n); Space complexity: O(log(n)) - height of a tree.
    public TreeNode SortedArrayToBST(int[] nums)
    {
        if (nums.Length == 0) return null;

        var mid = nums.Length / 2;
        var leftSide = nums.Take(mid).ToArray();
        var rightSide = nums.Skip(mid + 1).ToArray();

        var root = new TreeNode(nums[mid]);
        root.left = SortedArrayToBST(leftSide);
        root.right = SortedArrayToBST(rightSide);

        return root;
    }
}
using System.Linq;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Easy;

public class ConvertSortedArrayToBinarySearchTree
{
    // Time complexity: O(n); Space complexity: O(log(n)) - height of a tree.
    public TreeNode SortedArrayToBST(int[] nums) {
        if (nums.Length == 0)
        {
            return null;
        }

        var middleIndex = nums.Length / 2;
        var node = new TreeNode
        {
            val = nums[middleIndex],
        };

        var leftSide = nums.Take(middleIndex).ToArray();
        var rightSide = nums.Skip(middleIndex+1).ToArray();

        node.left = SortedArrayToBST(leftSide);
        node.right = SortedArrayToBST(rightSide);

        return node;
    }
}
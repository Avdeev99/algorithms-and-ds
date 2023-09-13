using System.Linq;

namespace ConsoleApp1.BlindSpot75;

public static class ConvertSortedArrayToBinarySearchTree
{
    public static TreeNode SortedArrayToBST(int[] nums) {
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
        var rightSide = nums.Skip(middleIndex + 1).ToArray();

        node.left = SortedArrayToBST(leftSide);
        node.right = SortedArrayToBST(rightSide);

        return node;
    }
}
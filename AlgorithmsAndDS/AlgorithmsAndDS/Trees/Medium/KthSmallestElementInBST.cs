using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Helpers;

namespace ConsoleApp1.Trees.Medium;

// 230. Kth Smallest Element in a BST
public class KthSmallestElementInBST
{
    // Time complexity: O(h); Space complexity: O(h).
    public int KthSmallest(TreeNode root, int k)
    {
        var stack = new Stack<TreeNode>();
        var curr = root;

        while (curr != null || stack.Any())
        {
            if (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }
            else
            {
                var prevNode = stack.Pop();
                k--;

                if (k == 0)
                    return prevNode.val;
                
                curr = prevNode.right;
            }
        }

        return -1;
    }
}
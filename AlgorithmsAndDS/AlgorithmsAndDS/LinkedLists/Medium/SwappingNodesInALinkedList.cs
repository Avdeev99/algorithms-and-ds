using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Medium;

// 1721. Swapping Nodes in a Linked List
public class SwappingNodesInALinkedList
{
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode SwapNodes(ListNode head, int k)
    {
        var fast = head;

        for (var i = 0; i < k - 1; i++)
            fast = fast?.next;

        if (fast.next == null)
        {
            (head.val, fast.val) = (fast.val, head.val);
            return head;
        }

        var nodeFromStart = fast;
        var nodeFromEnd = head;

        while (fast.next != null)
        {
            nodeFromEnd = nodeFromEnd.next;
            fast = fast.next;
        }

        (nodeFromStart.val, nodeFromEnd.val) = (nodeFromEnd.val, nodeFromStart.val);

        return head;
    }
}
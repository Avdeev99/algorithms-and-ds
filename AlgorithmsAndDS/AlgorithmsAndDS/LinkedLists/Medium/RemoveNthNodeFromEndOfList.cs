using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Medium;

// 19. Remove Nth Node From End of List
public class RemoveNthNodeFromEndOfList
{
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var slow = head;
        var fast = head;

        for (var i=0; i<n; i++) fast = fast?.next;

        if (fast == null) return head.next;

        while (fast.next != null)
        {
            slow = slow.next;
            fast = fast.next;
        }

        slow.next = slow.next.next;

        return head;
    }
}
using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Medium;

// 143. Reorder List
public class ReorderList
{
    // Time complexity: O(n); Space complexity: O(1).
    public void Reorder(ListNode head)
    {
        if (head == null) return;

        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next?.next;
        }

        ListNode prev = null;
        var curr = slow.next;
        slow.next = null;

        while (curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        var first = head;
        var last = prev;

        while (first != null && last != null)
        {
            var temp = first.next;
            first.next = last;
            last = last.next;
            first.next.next = temp;
            first = first.next.next;
        }
    }
}
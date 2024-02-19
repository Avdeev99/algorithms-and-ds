using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Medium;

// 61. Rotate List
public class RotateList
{
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode RotateRight(ListNode head, int k)
    {
        if (head == null) return null;

        var length = 0;
        var curr = head;

        while (curr != null)
        {
            length++;
            curr = curr.next;
        }

        k = k % length;

        if (k == 0) return head;

        var fast = head;

        for (var i = 0; i < k - 1; i++)
            fast = fast.next;

        ListNode prev = null;
        curr = head;

        while (fast.next != null)
        {
            var temp = curr;
            curr = curr.next;
            prev = temp;
            fast = fast.next;
        }

        prev.next = null;
        fast.next = head;

        return curr;
    }
}
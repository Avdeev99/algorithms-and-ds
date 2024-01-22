using ConsoleApp1.Helpers;

namespace ConsoleApp1.LinkedLists.Medium;

// 92. Reverse Linked List II
public class ReverseLinkedListII
{
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (head == null) return null;

        var dummy = new ListNode(0, head);
        var prev = dummy;
        var curr = head;
        var position = 1;

        while (curr != null)
        {
            if (position == left)
                break;

            prev = curr;
            curr = curr.next;
            position++;
        }

        var prevLeftNode = prev;
        var leftNode = curr;

        while (curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;

            if (position == right)
                break;

            position++;
        }

        var rightNode = prev;
        var rightNodeNext = curr;

        prevLeftNode.next = rightNode;
        leftNode.next = rightNodeNext;

        return dummy.next;
    }
}
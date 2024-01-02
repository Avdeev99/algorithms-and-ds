using ConsoleApp1.BlindSpot75;

namespace ConsoleApp1.LinkedLists.Easy;

// 203. Remove Linked List Elements
public class RemoveLinkedListElements
{
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode RemoveElements(ListNode head, int val)
    {
        var dummy = new ListNode(next: head);

        var prev = dummy;
        var curr = head;

        while (curr != null)
        {
            if (curr.val == val)
                prev.next = curr.next;
            else
                prev = curr;
            
            curr = curr.next;
        }

        return dummy.next;  
    }
}
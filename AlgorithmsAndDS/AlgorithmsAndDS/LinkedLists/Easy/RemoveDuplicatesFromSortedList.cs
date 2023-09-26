using ConsoleApp1.Helpers;

namespace ConsoleApp1.LinkedLists.Easy;

// Time complexity: O(n); Space complexity: O(1).
public class RemoveDuplicatesFromSortedList
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        if (head == null)
            return null;

        var curr = head;

        while (curr != null)
        {
            while (curr.next != null && curr.next.val == curr.val)
                curr.next = curr.next.next;
            
            curr = curr.next;
        }

        return head;
    }
}
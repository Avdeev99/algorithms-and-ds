using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Easy;

// 83. Remove Duplicates from Sorted List
public class RemoveDuplicatesFromSortedList
{
    // Time complexity: O(n); Space complexity: O(1).
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
    
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode DeleteDuplicates2(ListNode head)
    {
        ListNode prev = null;
        var curr = head;

        while (curr != null)
        {
            if (curr.val == prev?.val)
                prev.next = curr.next;
            else
                prev = curr;

            curr = curr.next;
        }

        return head;
    }
}
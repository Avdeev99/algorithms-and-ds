using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Medium;

// 147. Insertion Sort List
public class InsertionSortList
{
    // Time complexity: O(n^2); Space complexity: O(1)
    public ListNode InsertionSort(ListNode head)
    {
        var dummy = new ListNode(0, head);

        var curr = head.next;
        var prev = head;

        while (curr != null)
        {
            if (curr.val > prev.val)
            {
                prev = curr;
                curr = curr.next;
                continue;
            }

            var pointer = dummy;

            while (pointer.next != null && curr.val > pointer.next.val)
            {
                pointer = pointer.next;
            }

            prev.next = curr.next;
            curr.next = pointer.next;
            pointer.next = curr;
            curr = prev.next;
        }

        return dummy.next;  
    }
}
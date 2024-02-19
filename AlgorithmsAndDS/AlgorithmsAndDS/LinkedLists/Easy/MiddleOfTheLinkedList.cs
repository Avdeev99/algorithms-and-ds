using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Easy;

// 876. Middle of the Linked List
public class MiddleOfTheLinkedList
{
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode MiddleNode(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        return slow;
    }
}
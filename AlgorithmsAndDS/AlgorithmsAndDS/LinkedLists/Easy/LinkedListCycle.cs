using ConsoleApp1.Helpers;

namespace ConsoleApp1.LinkedLists.Easy;

// 141. Linked List Cycle
public class LinkedListCycle
{
    // Time complexity: O(n); Space complexity: O(1).
    public bool HasCycle(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (slow != null && fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next?.next;

            if (slow == fast) return true;
        }

        return false;
    }
}
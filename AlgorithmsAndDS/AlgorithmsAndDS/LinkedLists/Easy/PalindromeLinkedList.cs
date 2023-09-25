using ConsoleApp1.Helpers;

namespace ConsoleApp1.LinkedLists.Easy;

public class PalindromeLinkedList
{
    // Time complexity: O(n); Space complexity: O(1).
    public bool IsPalindrome(ListNode head)
    {
        var slow = head;
        var fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var previous = slow;
        slow = slow.next;
        previous.next = null;

        // reverse second part of the list
        while (slow != null)
        {
            var temp = slow.next;
            slow.next = previous;
            previous = slow;
            slow = temp;
        }

        fast = head;
        slow = previous;

        while (slow != null)
        {
            if (slow.val != fast.val) return false;
            fast = fast.next;
            slow = slow.next;
        }

        return true;
    }
}
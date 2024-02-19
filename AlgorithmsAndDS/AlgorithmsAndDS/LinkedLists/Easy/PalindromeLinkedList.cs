using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Easy;

// 234. Palindrome Linked List
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
            fast = fast?.next?.next;
        }

        ListNode prev = null;
        var curr = slow;

        // reverse second part of the list
        while (curr != null)
        {
            var temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        var start = head;
        var end = prev;

        while (end != null && start != null)
        {
            if (end.val != start.val)
                return false;

            start = start.next;
            end = end.next;
        }

        return true;
    }
}
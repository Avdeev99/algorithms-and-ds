using ConsoleApp1.Helpers;

namespace ConsoleApp1.LinkedLists.Easy;

public class IntersectionOfTwoLinkedLists
{
    // Time complexity: O(n + m); Space complexity: O(1).
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        if (headA == null || headB == null) return null;

        var pointerA = headA;
        var pointerB = headB;

        while (pointerA != pointerB)
        {
            pointerA = pointerA == null ? headB : pointerA.next;
            pointerB = pointerB == null ? headA : pointerB.next;
        }

        return pointerA;
    }
}
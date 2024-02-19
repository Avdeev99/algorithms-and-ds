using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Medium;

// 2. Add Two Numbers
public class AddTwoNumbers
{
    // Time complexity: O(n); Space complexity: O(n).
    public ListNode Add(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode();
        var curr = dummy;
        var valueToAdd = 0;

        while (l1 != null || l2 != null || valueToAdd > 0)
        {
            var l1Val = l1?.val ?? 0;
            var l2Val = l2?.val ?? 0;
            var val = l1Val + l2Val + valueToAdd;

            valueToAdd = val / 10;
            val %= 10;

            curr.next = new ListNode(val);
            curr = curr.next;
            l1 = l1?.next;
            l2 = l2?.next;
        }

        return dummy.next;
    }
}
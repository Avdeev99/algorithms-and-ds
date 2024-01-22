using ConsoleApp1.Helpers;

namespace ConsoleApp1.LinkedLists.Medium;

// 86. Partition List
public class PartitionList
{
    // Time complexity: O(n); Space complexity: O(n).
    public ListNode Partition(ListNode head, int x)
    {
        if (head == null) return null;

        var smallerPrevHead = new ListNode();
        var smallerNode = smallerPrevHead;

        var greaterPrevHead = new ListNode();
        var greaterNode = greaterPrevHead;

        var curr = head;

        while (curr != null)
        {
            if (curr.val >= x)
            {
                greaterNode.next = curr;
                greaterNode = greaterNode.next;
            }
            else
            {
                smallerNode.next = curr;
                smallerNode = smallerNode.next;
            }

            curr = curr.next;
        }

        greaterNode.next = null;
        smallerNode.next = greaterPrevHead.next;

        return smallerPrevHead.next;
    }
}
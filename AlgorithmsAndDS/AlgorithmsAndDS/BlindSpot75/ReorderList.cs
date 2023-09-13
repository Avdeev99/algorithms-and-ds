namespace ConsoleApp1.BlindSpot75;

public static class ReorderList
{
    public static void Reorder(ListNode head)
    {
        if(head==null||head.next==null) return;

        var slow = head;
        var fast = head;

        while (fast.next != null && fast.next.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        var currentNode = slow.next;
        slow.next = null;
        var prevNode = slow;

        while (currentNode != null)
        {
            var temp = currentNode.next;
            currentNode.next = prevNode;
            prevNode = currentNode;
            currentNode = temp;
        }

        var left = head;
        var right = prevNode;

        while (left != null && right != null && left != right)
        {
            var temp = left.next;
            left.next = right;
            right = right.next;
            left.next.next = temp;
            left = left.next.next;
        }
    }
}
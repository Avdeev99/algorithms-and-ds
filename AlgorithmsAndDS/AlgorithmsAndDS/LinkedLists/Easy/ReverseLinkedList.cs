using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Easy;

// 206. Reverse Linked List
public class ReverseLinkedList
{
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode ReverseList(ListNode head)
    {
        ListNode prevNode = null;
        var currNode = head;

        while (currNode != null)
        {
            var temp = currNode.next;
            currNode.next = prevNode;
            prevNode = currNode;
            currNode = temp;
        }

        return prevNode;
    }
}
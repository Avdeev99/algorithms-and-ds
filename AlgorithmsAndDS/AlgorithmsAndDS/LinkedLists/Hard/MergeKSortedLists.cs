using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Hard;

// 23. Merge k Sorted Lists
public class MergeKSortedLists
{
    // Time complexity: O(n*log(n)); Space complexity: O(n).
    public ListNode MergeKLists(ListNode[] lists)
    {
        var minHeap = new PriorityQueue<ListNode, int>();

        foreach (var node in lists)
        {
            if (node != null)
                minHeap.Enqueue(node, node.val);
        }

        var dummy = new ListNode();
        var curr = dummy;

        while (minHeap.Count > 0)
        {
            var minNode = minHeap.Dequeue();
            curr.next = minNode;

            if (minNode.next != null)
                minHeap.Enqueue(minNode.next, minNode.next.val);

            curr = curr.next;
        }

        return dummy.next;
    }
    
    // Time complexity: O(n*log(n)); Space complexity: O(n).
    public ListNode MergeKListsRecursively(ListNode[] lists)
    {
        if (lists == null || lists?.Length == 0)
            return null;

        var head = lists[0];

        for (var i = 1; i < lists.Length; i++)
        {
            if (lists[i] == null)
                continue;

            head = MergeTwoLists(head, lists[i]);
        }

        return head;
    }

    public ListNode MergeTwoLists(ListNode node1, ListNode node2)
    {
        if (node1 == null) return node2;

        if (node2 == null) return node1;

        if (node1.val <= node2.val)
        {
            node1.next = MergeTwoLists(node1.next, node2);
            return node1;
        }
        else
        {
            node2.next = MergeTwoLists(node2.next, node1);
            return node2;
        }
    }
}
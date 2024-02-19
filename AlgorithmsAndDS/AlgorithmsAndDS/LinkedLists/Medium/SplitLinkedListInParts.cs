using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Medium;

// 725. Split Linked List in Parts
public class SplitLinkedListInParts
{
    // Time complexity: O(n); Space complexity: O(n).
    public ListNode[] SplitListToParts(ListNode head, int k)
    {
        var length = 0;
        var curr = head;

        while (curr != null)
        {
            length++;
            curr = curr.next;
        }

        var partSize = length / k;
        var mod = length % k;
        var result = new ListNode[k];
        curr = head;

        for (var i = 0; i < k; i++)
        {
            result[i] = curr;
            
            var size = mod > 0
                ? partSize + 1
                : partSize;

            for (var j = 0; j < size - 1 && curr != null; j++)
            {
                curr = curr.next;
            }

            mod--;

            if (curr == null) continue;

            var temp = curr.next;
            curr.next = null;
            curr = temp;
        }

        return result;
    }

    // Time complexity: O(n); Space complexity: O(n).
    public ListNode[] SplitListToPartsRecursive(ListNode head, int k)
    {
        var length = 0;
        var curr = head;

        while (curr != null)
        {
            length++;
            curr = curr.next;
        }

        var partSize = length / k;
        var mod = length % k;

        var result = new ListNode[k];
        Helper(head, partSize, mod, 0, result);

        return result;
    }

    private void Helper(ListNode head, int size, int mod, int index, ListNode[] result)
    {
        if (head == null) return;
        
        ListNode prev = null;
        var curr = head;

        for (var i = 0; i < size; i++)
        {
            prev = curr;
            curr = curr.next;
        }

        if (curr != null && mod > 0)
        {
            prev = curr;
            curr = curr.next;
            mod--;
        }

        prev.next = null;
        result[index++] = head;
        Helper(curr, size, mod, index, result);
    }
}
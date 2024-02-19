using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Easy;

// 21. Merge Two Sorted Lists
public class MergeTwoSortedLists
{
    // Time complexity: O(n); Space complexity: O(1).
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummyNode = new ListNode();
        var currNode = dummyNode;

        while(list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                currNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                currNode.next = list2;
                list2 = list2.next;
            }

            currNode = currNode.next;
        }

        currNode.next = list1 ?? list2;

        return dummyNode.next;
    }
    
    // Time complexity: O(n); Space complexity: O(n).
    public ListNode MergeTwoListsRecursively(ListNode list1, ListNode list2)
    {
        if(list1 == null)
        {
            return list2;
        }

        if(list2 == null)
        {
            return list1;
        }

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next , list2);
            return list1;
        }

        list2.next = MergeTwoLists(list2.next , list1);

        return list2;
    }
}
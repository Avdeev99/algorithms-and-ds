namespace ConsoleApp1.BlindSpot75
{
    public class MergeTwoSortedLists
    {
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
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
        
        public static ListNode MergeTwoLists2(ListNode list1, ListNode list2)
        {
            var dummy = new ListNode();
            var current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    current.next = list2;
                    list2 = list2.next;
                }

                current = current.next;
            }

            current.next = list1 ?? list2;

            return dummy.next;
        }
        
        public static ListNode MergeTwoLists3(ListNode list1, ListNode list2) {
            if (list1 == null && list2 == null)
            {
                return null;
            }
        
            if (list1 == null || list2 == null)
            {
                return list1 ?? list2;
            }
        
            var list2StepNode = list2;
            ListNode list1PreviousStepNode = null;
            var list1StepNode = list1;
            var resultHead = list1;

            while (list2StepNode != null)
            {
                if (list1StepNode == null)
                {
                    list1PreviousStepNode.next = list2StepNode;
                    list2StepNode = list2StepNode.next;

                    continue;
                }
                
                if (list1PreviousStepNode == null)
                {
                    if (list2StepNode.val > list1StepNode.val)
                    {
                        continue;
                    }
                    
                    list2StepNode.next = list1StepNode;
                    resultHead = list2StepNode;
                    
                    list2StepNode = list2StepNode.next;
                    list1PreviousStepNode = list1StepNode;
                    list1StepNode = list1StepNode.next;
                }
                else
                {
                    if (list2StepNode.val <= list1StepNode.val)
                    {
                        list1PreviousStepNode.next = list2StepNode;
                        list2StepNode.next = list1StepNode;
                
                        list2StepNode = list2StepNode.next;
                    }
                    else
                    {
                        list1PreviousStepNode = list1StepNode;
                        list1StepNode = list1StepNode.next;
                    }
                }
            }
        
            return resultHead;
        }
    }
}
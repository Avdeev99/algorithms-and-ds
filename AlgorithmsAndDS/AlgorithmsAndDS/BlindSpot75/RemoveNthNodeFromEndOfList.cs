namespace AlgorithmsAndDS.BlindSpot75
{
    public static class RemoveNthNodeFromEndOfList
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode fast = head;
        
            //place fast node ahead of n node
            while (n-- > 0)
                fast = fast.next;
        
            //if fast aleady reached to end
            //just remove the first element and return
            if (fast == null)
                return head.next;
        
            //else create a slow pointer & start moving
            ListNode slow = head;
        
            while (fast.next != null) 
            {
                fast = fast.next;
                slow = slow.next;
            }
        
            slow.next = slow.next.next;
        
            return head;
        }
        
        public static ListNode RemoveNthFromEnd2(ListNode head, int n)
        {
            if (head == null)
            {
                throw new ArgumentException();
            }

            var index = 0;
            var nodes = new Dictionary<int, ListNode>();
            
            var stepNode = head;

            while (stepNode != null)
            {
                nodes.Add(index, stepNode);

                if (stepNode.next != null)
                {
                    index++;
                }
                
                stepNode = stepNode.next;
            }

            var positionToDelete = index + 1 - n;
            var previousNodePosition = positionToDelete - 1;

            if (positionToDelete == 0)
            {
                head = head.next;

                return head;
            }

            var nodeToDelete = nodes[positionToDelete];
            var previousNode = nodes[previousNodePosition];

            var nextNode = nodeToDelete.next;
            previousNode.next = nextNode;

            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
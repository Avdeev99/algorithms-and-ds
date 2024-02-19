using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.LinkedLists.Medium;

// 1472. Design Browser History
// Space complexity: O(n).
public class DesignBrowserHistory
{
    DoubleListNode curr;

    public DesignBrowserHistory(string homepage) 
    {
        curr = new DoubleListNode(homepage);
    }
    
    // Time complexity: O(1);
    public void Visit(string url) 
    {
        curr.next = new DoubleListNode(url, curr);
        curr = curr.next;
    }
    
    // Time complexity: O(n);
    public string Back(int steps) 
    {
        while(curr.prev != null && steps > 0)
        {
            curr = curr.prev;
            steps--;
        }

        return curr.val;
    }
    
    // Time complexity: O(n);
    public string Forward(int steps) 
    {
        while(curr.next != null && steps > 0)
        {
            curr = curr.next;
            steps--;
        }

        return curr.val;
    }
}
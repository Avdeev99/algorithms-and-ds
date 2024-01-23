namespace ConsoleApp1.Helpers;

public class DoubleListNode
{
    public string val { get; set; }
    public DoubleListNode next { get; set; }
    public DoubleListNode prev { get; set; }
    
    public DoubleListNode(string val, DoubleListNode prev = null, DoubleListNode next = null)
    {
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}
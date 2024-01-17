using System.Collections.Generic;

namespace ConsoleApp1.LinkedLists.Medium;

// 138. Copy List with Random Pointer
public class CopyListWithRandomPointer
{
    // Time complexity: O(n); Space complexity: O(n).
    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;

        var map = new Dictionary<Node, Node>();
        var dummy = new Node(0);
        var curr = head;
        
        while (curr != null)
        {
            dummy.next = GetNewNode(curr, map);
            dummy = dummy.next;
            curr = curr.next;
        }

        return map[head];
    }

    private Node GetNewNode(Node node, Dictionary<Node, Node> map)
    {
        if (node == null) return null;

        if (map.ContainsKey(node))
            return map[node];
        
        var newNode = new Node(node.val);
        map[node] = newNode;

        newNode.random = GetNewNode(node.random, map);

        return newNode;
    }
}

public class Node
{
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
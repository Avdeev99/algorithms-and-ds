using AlgorithmsAndDS.Helpers;

namespace AlgorithmsAndDS.Graphs.Medium;

// 133. Clone Graph
public class CloneGraph
{
    private readonly Dictionary<GraphNode, GraphNode> map = new();

    // Time complexity: O(n); Space complexity: O(n).
    public GraphNode Clone(GraphNode node)
    {
        if (node == null)
            return null;

        if (map.TryGetValue(node, out var clone))
            return clone;

        var newNode = new GraphNode(node.val);
        map[node] = newNode;

        foreach (var neighbor in node.neighbors)
        {
            var newNeighbor = Clone(neighbor);
            newNode.neighbors.Add(newNeighbor);
        }

        return newNode;
    }
    
    // Time complexity: O(n); Space complexity: O(n).
    public GraphNode CloneIterative(GraphNode node) {
        if (node == null) return null;

        var nodesMap = new Dictionary<GraphNode, GraphNode>();
        
        var queue = new Queue<GraphNode>();
        queue.Enqueue(node);

        while (queue.Count > 0)
        {
            var curr = queue.Dequeue();

            if (!nodesMap.ContainsKey(curr))
            {
                nodesMap[curr] = new GraphNode(curr.val);
            }

            var clone = nodesMap[curr];

            foreach (var neighbor in curr.neighbors)
            {
                if (!nodesMap.ContainsKey(neighbor))
                {
                    nodesMap[neighbor] = new GraphNode(neighbor.val);
                    queue.Enqueue(neighbor);
                }

                clone.neighbors.Add(nodesMap[neighbor]);
            }
        }

        return nodesMap[node];
    }
}
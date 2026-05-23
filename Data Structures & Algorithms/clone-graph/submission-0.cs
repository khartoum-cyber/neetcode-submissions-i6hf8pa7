/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution 
{
    public Node CloneGraph(Node node) 
    {
        if (node == null)
            return null;

        Dictionary<Node, Node> map = new();
        return Clone(node, map);
    }

    private Node Clone(Node node, Dictionary<Node, Node> map)
    {
        if (node == null)
            return null;

        if (map.ContainsKey(node))
            return map[node];

        var clone = new Node(node.val);
        map[node] = clone;

        foreach(var neighbor in node.neighbors)
        {
            var clonedNeighbor = Clone(neighbor, map);
            clone.neighbors.Add(clonedNeighbor);
        }

        return clone;
    }
}

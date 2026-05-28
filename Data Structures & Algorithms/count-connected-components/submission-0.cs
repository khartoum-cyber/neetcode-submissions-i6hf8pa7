public class Solution {
    public int CountComponents(int n, int[][] edges) 
    {
        List<List<int>> adj = new();
        bool[] visited = new bool[n];

        for(int i = 0; i < n; i++)
        {
            adj.Add(new List<int>());
        }

        foreach(var edge in edges)
        {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        int components = 0;
        for(int node = 0; node < n; node++)
        {
            if(!visited[node])
            {
                BFS(adj, visited, node);
                components++;
            }
        }

        return components;
    }

    private void BFS(List<List<int>> adj, bool[] visited, int node)
    {
        Queue<int> q = new();
        q.Enqueue(node);
        visited[node] = true;

        while(q.Count > 0)
        {
            int curr = q.Dequeue();

            foreach(var nei in adj[curr])
            {
                if(!visited[nei])
                {
                    visited[nei] = true;
                    q.Enqueue(nei);
                }
            }
        }
    }
}

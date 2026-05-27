public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) 
    {
        List<List<int>> adjList = new();

        for(int i = 0; i < numCourses; i++)
        {
            adjList.Add(new List<int>());
        }

        foreach(var p in prerequisites)
        {
            int course = p[0];
            int prereq = p[1];

            adjList[prereq].Add(course);
        }

        bool[] visited = new bool[numCourses];
        HashSet<int> path = new();

        for(int i = 0; i < numCourses; i++)
        {
            if(!DFS(i, adjList, visited, path))
                return false;
        }

        return true;
    }


    private bool DFS(int node, List<List<int>> adj, bool[] visited, HashSet<int> path)
    {
        if (path.Contains(node))
            return false; // cycle found

        if (visited[node])
            return true; // already processed

        path.Add(node);

        foreach (var neighbor in adj[node])
        {
            if (!DFS(neighbor, adj, visited, path))
                return false;
        }

        path.Remove(node);
        visited[node] = true;

        return true;
    }

}

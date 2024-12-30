using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode1971
{
    public class Solution
    {
        public Dictionary<int, List<int>> adjacentNodes = new Dictionary<int, List<int>>();
        public bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            if (n==1 && edges.Length==0)
            {
                return true;
            }
            for (int i=0; i< edges.Length; i++)
            {
                AddEdge(edges[i][0], edges[i][1]);
            }
            bool foundVal = BFS(source, destination);
            return foundVal;
        }

        public bool BFS(int source, int destination)
        {
            HashSet<int> visited = new HashSet<int>();
            Queue<int> queue = new Queue<int>();
            visited.Add(source);
            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                int vertex = queue.Dequeue();
                foreach(var neigbour in adjacentNodes[vertex])
                {
                    if (neigbour == destination)
                    {
                        return true;
                    }
                    else if (!visited.Contains(neigbour))
                    {
                        
                        visited.Add(neigbour);
                        queue.Enqueue(neigbour);
                    }
                }
            }
            return false;
        }
        public void AddEdge(int x, int y)
        {
            AddVertex(x);
            AddVertex(y);

            adjacentNodes[x].Add(y);
            adjacentNodes[y].Add(x);
        }
        public void AddVertex(int x)
        {
            if(!adjacentNodes.ContainsKey(x))
            {
                adjacentNodes[x] = new List<int>();
            }
        }
    }
}

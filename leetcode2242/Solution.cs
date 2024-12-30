using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2242
{
    public class Solution
    {
        private Dictionary<int, List<int>> adjacencyList = new Dictionary<int, List<int>>();
        private Dictionary<int, List<int>> topNeighborsCache = new Dictionary<int, List<int>>();

        public int MaximumScore(int[] scores, int[][] edges)
        {
            if (scores.Length < 4 || edges.Length == 0)
                return -1;

            // Build adjacency list
            foreach (var edge in edges)
            {
                AddEdge(edge[0], edge[1]);
            }

            // Precompute top neighbors for each node
            foreach (var node in adjacencyList.Keys)
            {
                topNeighborsCache[node] = adjacencyList[node]
                    .OrderByDescending(neighbor => scores[neighbor])
                    .Take(3)
                    .ToList();
            }

            int maxScore = -1;

            // Traverse all edges to calculate the maximum score
            foreach (var edge in edges)
            {
                int u = edge[0];
                int v = edge[1];

                // Get top neighbors for u and v
                var neighborsU = topNeighborsCache[u];
                var neighborsV = topNeighborsCache[v];

                // Calculate maximum score for all valid combinations
                foreach (var neighborU in neighborsU)
                {
                    foreach (var neighborV in neighborsV)
                    {
                        if (neighborU != neighborV && neighborU != v && neighborV != u)
                        {
                            int currentScore = scores[u] + scores[v] + scores[neighborU] + scores[neighborV];
                            maxScore = Math.Max(maxScore, currentScore);
                        }
                    }
                }
            }

            return maxScore;
        }

        private void AddEdge(int x, int y)
        {
            AddVertex(x);
            AddVertex(y);
            adjacencyList[x].Add(y);
            adjacencyList[y].Add(x);
        }

        private void AddVertex(int x)
        {
            if (!adjacencyList.ContainsKey(x))
            {
                adjacencyList[x] = new List<int>();
            }
        }
    }
  
}

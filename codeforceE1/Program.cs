using System;
using System.Collections.Generic;
using System.Linq;

// https://codeforces.com/contest/2057/problem/E1 
public class Graph
{
    private readonly Dictionary<int, List<(int, int)>> _adjacencyList; // Node -> List of (Neighbor, Weight)

    public Graph()
    {
        _adjacencyList = new Dictionary<int, List<(int, int)>>();
    }

    public void AddEdge(int u, int v, int weight)
    {
        if (!_adjacencyList.ContainsKey(u))
        {
            _adjacencyList[u] = new List<(int, int)>();
        }
        if (!_adjacencyList.ContainsKey(v))
        {
            _adjacencyList[v] = new List<(int, int)>();
        }

        _adjacencyList[u].Add((v, weight));
        _adjacencyList[v].Add((u, weight)); // Since the graph is undirected
    }

    public List<List<int>> FindPaths(int src, int dest)
    {
        var visited = new HashSet<int>();
        var path = new List<int>();
        var paths = new List<List<int>>();

        FindPathsHelper(src, dest, visited, path, paths);
        return paths;
    }

    private void FindPathsHelper(int current, int dest, HashSet<int> visited, List<int> path, List<List<int>> paths)
    {
        visited.Add(current);
        path.Add(current);

        if (current == dest)
        {
            paths.Add(new List<int>(path));
        }
        else
        {
            if (_adjacencyList.ContainsKey(current))
            {
                foreach (var neighbor in _adjacencyList[current])
                {
                    if (!visited.Contains(neighbor.Item1))
                    {
                        FindPathsHelper(neighbor.Item1, dest, visited, path, paths);
                    }
                }
            }
        }

        path.RemoveAt(path.Count - 1);
        visited.Remove(current);
    }

    public int GetMinimumOfKthLargestWeights(int src, int dest, int k)
    {
        var paths = FindPaths(src, dest);
        var kthLargestWeights = new List<int>();

        foreach (var path in paths)
        {
            var pathWeights = GetPathWeights(path);
            if (pathWeights.Count >= k)
            {
                pathWeights.Sort();
                kthLargestWeights.Add(pathWeights[^k]); // Select the kth largest weight from the sorted list
            }
        }

        return kthLargestWeights.Min(); // Return the minimum of all kth largest weights
    }

    private List<int> GetPathWeights(List<int> path)
    {
        var weights = new List<int>();

        for (int i = 0; i < path.Count - 1; i++)
        {
            var u = path[i];
            var v = path[i + 1];

            foreach (var neighbor in _adjacencyList[u])
            {
                if (neighbor.Item1 == v)
                {
                    weights.Add(neighbor.Item2);
                    break;
                }
            }
        }

        return weights;
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of test cases: ");
        int t = int.Parse(Console.ReadLine());

        for (int testCase = 1; testCase <= t; testCase++)
        {
            Console.WriteLine($"Test Case {testCase}:");
            Console.Write("Enter the number of vertices (n), edges (m), and queries (q): ");
            var inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int q = int.Parse(inputs[2]);

            var graph = new Graph();

            Console.WriteLine("Enter edges (u, v, w):");
            for (int i = 0; i < m; i++)
            {
                var edgeInput = Console.ReadLine().Split();
                int u = int.Parse(edgeInput[0]);
                int v = int.Parse(edgeInput[1]);
                int w = int.Parse(edgeInput[2]);
                graph.AddEdge(u, v, w);
            }

            Console.WriteLine("Enter queries (source, destination, k):");
            for (int i = 0; i < q; i++)
            {
                var queryInput = Console.ReadLine().Split();
                int source = int.Parse(queryInput[0]);
                int destination = int.Parse(queryInput[1]);
                int k = int.Parse(queryInput[2]);

                var result = graph.GetMinimumOfKthLargestWeights(source, destination, k);
                Console.WriteLine($"Query {i + 1}: Minimum of kth largest weights: {result}");
            }
        }
    }
}

//public class Graph
//{
//    private readonly Dictionary<int, List<(int, int)>> _adjacencyList; // Node -> List of (Neighbor, Weight)

//    public Graph()
//    {
//        _adjacencyList = new Dictionary<int, List<(int, int)>>();
//    }

//    public void AddEdge(int u, int v, int weight)
//    {
//        if (!_adjacencyList.ContainsKey(u))
//        {
//            _adjacencyList[u] = new List<(int, int)>();
//        }
//        if (!_adjacencyList.ContainsKey(v))
//        {
//            _adjacencyList[v] = new List<(int, int)>();
//        }

//        _adjacencyList[u].Add((v, weight));
//        _adjacencyList[v].Add((u, weight)); // Since the graph is undirected
//    }

//    public List<List<int>> FindPaths(int src, int dest)
//    {
//        var visited = new HashSet<int>();
//        var path = new List<int>();
//        var paths = new List<List<int>>();

//        FindPathsHelper(src, dest, visited, path, paths);
//        return paths;
//    }

//    private void FindPathsHelper(int current, int dest, HashSet<int> visited, List<int> path, List<List<int>> paths)
//    {
//        visited.Add(current);
//        path.Add(current);

//        if (current == dest)
//        {
//            paths.Add(new List<int>(path));
//        }
//        else
//        {
//            if (_adjacencyList.ContainsKey(current))
//            {
//                foreach (var neighbor in _adjacencyList[current])
//                {
//                    if (!visited.Contains(neighbor.Item1))
//                    {
//                        FindPathsHelper(neighbor.Item1, dest, visited, path, paths);
//                    }
//                }
//            }
//        }

//        path.RemoveAt(path.Count - 1);
//        visited.Remove(current);
//    }

//    public int GetMinimumOfKthLargestWeights(int src, int dest, int k)
//    {
//        var paths = FindPaths(src, dest);
//        var kthLargestWeights = new List<int>();

//        foreach (var path in paths)
//        {
//            var pathWeights = GetPathWeights(path);
//            if (pathWeights.Count >= k)
//            {
//                pathWeights.Sort();
//                kthLargestWeights.Add(pathWeights[^k]); // Select the kth largest weight from the sorted list
//            }
//        }

//        return kthLargestWeights.Min(); // Return the minimum of all kth largest weights
//    }

//    private List<int> GetPathWeights(List<int> path)
//    {
//        var weights = new List<int>();

//        for (int i = 0; i < path.Count - 1; i++)
//        {
//            var u = path[i];
//            var v = path[i + 1];

//            foreach (var neighbor in _adjacencyList[u])
//            {
//                if (neighbor.Item1 == v)
//                {
//                    weights.Add(neighbor.Item2);
//                    break;
//                }
//            }
//        }

//        return weights;
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var graph = new Graph();

//        graph.AddEdge(1, 2, 10);
//        graph.AddEdge(2, 4, 10);
//        graph.AddEdge(2, 3, 3);
//        graph.AddEdge(3, 4, 9);
//        graph.AddEdge(4, 5, 2);
//        graph.AddEdge(5, 6, 1);
//        graph.AddEdge(4, 6, 10);

//        int source = 1;
//        int target = 6;
//        int k = 3;

//        var result = graph.GetMinimumOfKthLargestWeights(source, target, k);

//        Console.WriteLine("Final array of weights <= k: " + string.Join(", ", result));
//    }
//}





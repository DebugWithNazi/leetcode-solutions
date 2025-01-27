class Program
{
    public class Graph
    {
        private Dictionary<int, List<(int, int)>> _adjacancyList;

        public Graph()
        {
            _adjacancyList = new Dictionary<int, List<(int, int)>>();
        }

        public void AddEdges(int u, int v, int w)
        {
            if (!_adjacancyList.ContainsKey(u))
            {
                _adjacancyList[u] = new List<(int, int)>();
            }
            if (!_adjacancyList.ContainsKey(v))
            {
                _adjacancyList[v] = new List<(int, int)>();
            }

            _adjacancyList[u].Add((v, w));
            _adjacancyList[v].Add((u, w));
        }
        public List<List<int>> FindPaths(int src, int dest)
        {
            var visited = new HashSet<int>();
            var path = new List<int>();
            var paths = new List<List<int>>();

            FindPathsHelper(src, dest, visited, path, paths);
            return paths;
        }
        public void FindPathsHelper(int source, int destination, HashSet<int> visited, List<int> path, List<List<int>> paths)
        {
            visited.Add(source);
            path.Add(source);
            if (source == destination)
            {
                paths.Add(new List<int>(path));
            }
            else
            {
                if (_adjacancyList.ContainsKey(source))
                {
                    foreach (var neigbor in _adjacancyList[source])
                    {
                        if (!visited.Contains(neigbor.Item1))
                        {
                            FindPathsHelper(neigbor.Item1, destination, visited, path, paths);
                        }
                    }
                }
            }

            visited.Remove(source);
            path.RemoveAt(path.Count - 1);

        }
        public int GetMinimumOfKthLargestWeights(int source, int destination, int k)
        {

            var pathLists = FindPaths(source, destination);
            var kthLargestWeights = new List<int>();

            foreach (var p in pathLists)
            {
                var weights = FindWieghts(p);
                if (weights.Count >= k)
                {
                    weights.Sort();
                    kthLargestWeights.Add(weights[^k]);
                }
            }
            return kthLargestWeights.Min();
        }

        public List<int> FindWieghts(List<int> path)
        {
            var weights = new List<int>();

            for (int i = 0; i < path.Count; i++)
            {
                int u = path[i];
                int v = path[i + 1];

                foreach (var neighbor in _adjacancyList[u])
                {
                    if (neighbor.Item1 == v)
                    {
                        weights.Add(neighbor.Item2);
                    }
                }
            }
            return weights;
        }
    }
    static void Main()
    {
        Console.WriteLine("give testcases: ");
        int t = int.Parse(Console.ReadLine());
        var graph = new Graph();

        for (int l = 0; l <= t; l++)
        {
            var inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            int q = int.Parse(inputs[2]);

            for (int k = 0; k < m; k++)
            {
                var edgeInputs = Console.ReadLine().Split();
                int u = int.Parse(edgeInputs[0]);
                int v = int.Parse(edgeInputs[1]);
                int w = int.Parse(edgeInputs[2]);
                graph.AddEdges(u, v, w);
            }

            for (int j = 0; j < q; j++)
            {
                var queries = Console.ReadLine().Split();
                int source = int.Parse(queries[0]);
                int destination = int.Parse(queries[1]);
                int k = int.Parse(queries[2]);

                var result = graph.GetMinimumOfKthLargestWeights(source, destination, k);
                Console.WriteLine($"Query : {j + 1}: Minimum of Kth Largest weights {result}");

            }

        }

    }
}
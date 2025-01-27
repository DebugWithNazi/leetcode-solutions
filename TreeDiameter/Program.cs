

using System.ComponentModel.Design;
using System.Net.Security;

class Graph
{
    public Dictionary<int, List<int>> _adjacancyList;
    public int _maxDistance = 0;
    public int _farthestNode = 0;
    public Graph()
    {
        _adjacancyList = new Dictionary<int, List<int>>();
    }

    public void AddEdges(int u, int v)
    {
        if (!_adjacancyList.ContainsKey(u))
        {
            _adjacancyList[u] = new List<int>();
        }
        if (!_adjacancyList.ContainsKey(v))
        {
            _adjacancyList[v] = new List<int>();
        }
        _adjacancyList[u].Add(v);
        _adjacancyList[v].Add(u);
    }

    public int FindDiameter()
    {
        _maxDistance = -1;
        DFS(1, -1, 0);
        int startNode = _farthestNode;

        _maxDistance = -1;
        DFS(startNode, -1, 0);

        return _maxDistance;
    }

    public void DFS(int node, int parent, int distance)
    {
        if (distance > _maxDistance)
        {
            _maxDistance = distance;
            _farthestNode = node;
        }

        foreach (var neighbor in _adjacancyList[node])
        {
            if (neighbor != parent)
            {
                DFS(neighbor, node, distance + 1);
            }
        }

    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Write the no. of nodes:");
        var n = int.Parse(Console.ReadLine());

        Console.WriteLine("Write the edges:");
        var graph = new Graph();
        for (int i = 0; i < n; i++)
        {
            var edge = Console.ReadLine().Split();
            var u = int.Parse(edge[0]);
            var v = int.Parse(edge[1]);
            graph.AddEdges(u, v);
        }

        var result = graph.FindDiameter();
        Console.WriteLine(result);
    }
}



//https://cses.fi/problemset/task/1675


class Edge
{
    public int edge1 { get; }
    public int edge2 { get; }
    public int cost { get; }

    public Edge(int edge1, int edge2, int cost)
    {
        this.edge1 = edge1;
        this.edge2 = edge2;
        this.cost = cost;
    }
}

class Graph
{
   
    public int Kruskals(int n , List<Edge> edges)
    {
         //step 1: sort the edges
         edges = edges.OrderBy(e => e.cost).ToList();

        //step2: initilize the arrays
        var uf = new UnionFind(n+1);

        int totalCost = 0;
        int edgeCount = 0;

        //step3: get the minimum spannig tree cost
        foreach (var edge in edges)
        {
            if (uf.Union(edge.edge1, edge.edge2))
            {
                totalCost = totalCost + edge.cost;
                edgeCount++;

                if(edgeCount == n - 1)
                {
                    break;
                }
            }
        }

        return edgeCount == n - 1 ? totalCost : -1;
    }
}
public class UnionFind
{
    public int[] Parent;
    public int[] Rank;
    public UnionFind(int n)
    {
        Parent = new int[n + 1];
        Rank = new int[n + 1];
        for (int i = 1; i <= n; i++)
        {
            Parent[i] = i;
            Rank[i] = 0;
        }
    }

    public int Find(int x)
    {
        if (Parent[x] != x)
        {
            Parent[x] = Find(Parent[x]);
        }
        return Parent[x];
    }

    public bool Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);

        if (rootX == rootY) return false;

        if (Rank[rootX] > Rank[rootY])
        {
            Parent[rootY] = rootX;
        }
        else if (Rank[rootX] < Rank[rootY])
        {
            Parent[rootX] = rootY;
        }
        else
        {
            Parent[rootY] = rootX;
            Rank[rootX]++;
        }
        return true;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter n (no of cities) and m ( no.of roads):");
        var input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);
        var graphs = new List<Edge>();
        Console.WriteLine("Enter the roads: ");
        for (int i = 0; i < m; i++)
        {
            input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            graphs.Add(new Edge(a, b, c));
        }
        var graph = new Graph();
        int result = graph.Kruskals(n, graphs);

        Console.WriteLine(result == -1 ? "IMPOSSIBLE" : result.ToString());


    }
}

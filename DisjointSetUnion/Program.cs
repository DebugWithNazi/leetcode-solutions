using System;

class DisjointSetUnion
{
    private int[] parent; // Parent array
    private int[] rank;   // Rank array to track tree depth

    public DisjointSetUnion(int size)
    {
        parent = new int[size];
        rank = new int[size];

        // Initialize each element as its own parent
        for (int i = 0; i < size; i++)
        {
            parent[i] = i;
            rank[i] = 0;
        }
    }

    // Find the root of the set containing x with path compression
    public int Find(int x)
    {
        if (parent[x] != x)
        {
            parent[x] = Find(parent[x]); // Path compression
        }
        return parent[x];
    }

    // Union two sets by rank
    public void Union(int x, int y)
    {
        int rootX = Find(x);
        int rootY = Find(y);

        if (rootX != rootY)
        {
            // Attach smaller tree under the root of the larger tree
            if (rank[rootX] > rank[rootY])
            {
                parent[rootY] = rootX;
            }
            else if (rank[rootX] < rank[rootY])
            {
                parent[rootX] = rootY;
            }
            else
            {
                parent[rootY] = rootX;
                rank[rootX]++;
            }
        }
    }

    // Check if two elements are in the same set
    public bool AreConnected(int x, int y)
    {
        return Find(x) == Find(y);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of elements: ");
        int n = int.Parse(Console.ReadLine());

        var dsu = new DisjointSetUnion(n);

        Console.WriteLine("Enter number of operations (e.g., union or connected check): ");
        int operations = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter operations (union x y or find x y):");
        for (int i = 0; i < operations; i++)
        {
            var input = Console.ReadLine().Split();
            string op = input[0];
            int x = int.Parse(input[1]);
            int y = int.Parse(input[2]);

            if (op == "union")
            {
                dsu.Union(x, y);
                Console.WriteLine($"Union({x}, {y}) performed.");
            }
            else if (op == "find")
            {
                bool connected = dsu.AreConnected(x, y);
                Console.WriteLine($"Find({x}, {y}): {connected}");
            }
        }
    }
}

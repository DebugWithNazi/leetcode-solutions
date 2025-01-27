using System;

class GridPaths
{
    const int MOD = 1000000007;

    public static int CountPaths(int n, char[,] grid)
    {
        // DP array to store the number of ways to reach each cell
        int[,] dp = new int[n, n];

        // Base case: Start point
        dp[0, 0] = grid[0, 0] == '.' ? 1 : 0;

        // Fill the DP table
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                // Skip blocked cells
                if (grid[i, j] == '#') continue;

                // Add paths from the top
                if (i > 0) dp[i, j] = (dp[i, j] + dp[i - 1, j]) % MOD;

                // Add paths from the left
                if (j > 0) dp[i, j] = (dp[i, j] + dp[i, j - 1]) % MOD;
            }
        }

        // The result is in the bottom-right corner
        return dp[n - 1, n - 1];
    }

    static void Main()
    {
        // Input
        Console.WriteLine("Enter grid size n:");
        int n = int.Parse(Console.ReadLine());
        char[,] grid = new char[n, n];

        Console.WriteLine("Enter the grid:");
        for (int i = 0; i < n; i++)
        {
            string row = Console.ReadLine();
            for (int j = 0; j < n; j++)
            {
                grid[i, j] = row[j];
            }
        }

        // Calculate and print the number of paths
        Console.WriteLine(CountPaths(n, grid));
    }
}

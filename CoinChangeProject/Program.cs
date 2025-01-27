
class Program
{
    public static int CoinChangeMinimum(int[] coins, int amount)
    {
        // Initialize the DP array with a large value (infinity equivalent)
        int[] dp = new int[amount + 1];
        Array.Fill(dp, int.MaxValue);
        dp[0] = 0; // Base case: 0 coins to make amount 0

        // Fill the DP array
        for (int x = 1; x <= amount; x++)
        {
            foreach (var coin in coins)
            {
                if (x >= coin && dp[x - coin] != int.MaxValue)
                {
                    dp[x] = Math.Min(dp[x], dp[x - coin] + 1);
                }
            }
        }

        // Return the result
        return dp[amount] == int.MaxValue ? -1 : dp[amount];
    }
}
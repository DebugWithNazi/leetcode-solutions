using leetcode2242;

Solution solution = new Solution();
int[] scores = new int[] { 5, 2, 9, 8, 4 };
int[][] nodes = new int[][] { [0, 1], [1, 2], [2, 3], [0, 2],
    [1, 3], [2, 4] };
Console.WriteLine(solution.MaximumScore(scores, nodes));
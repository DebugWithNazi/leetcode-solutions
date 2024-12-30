using leetcode1971;

Solution sol = new Solution();
int[][] edges = new int[][] { [0, 1], [0, 2], [3, 5], [5, 4], [4, 3] };
Console.WriteLine(sol.ValidPath(6,edges,0,5));
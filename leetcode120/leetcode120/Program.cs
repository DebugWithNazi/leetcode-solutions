using leetcode120;

Solution sol = new Solution();
IList<IList<int>> listOfLists = new List<IList<int>>();

// Insert values into the list of lists
listOfLists.Add(new List<int> { 2 });
listOfLists.Add(new List<int> { 3, 4 });
listOfLists.Add(new List<int> { 6, 5, 7 });
listOfLists.Add(new List<int> { 4, 1, 8, 3 });

Console.WriteLine(sol.MinimumTotal(listOfLists));
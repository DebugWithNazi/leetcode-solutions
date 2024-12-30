using leetcode15;

var solution = new Solution();
int[] nums = { -1, 0, 1, 2, -1, -4 };

var triplets = solution.ThreeSum(nums);

foreach (var triplet in triplets)
{
    Console.WriteLine(string.Join(", ", triplet));
}
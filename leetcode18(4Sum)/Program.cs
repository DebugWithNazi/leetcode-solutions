using leetcode18_4Sum_;

int[] nums = { 2, 2, 2, 2, 2 };
int target = 8;
Solution solution = new Solution();
var result = solution.FourSum(nums, target);

foreach (var quad in result)
{
    Console.WriteLine(string.Join(", ", quad));
}
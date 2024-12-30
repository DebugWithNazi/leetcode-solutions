using leetcode18;

Solution sol =new Solution();
int[] arr = new int[] { 1, 0, -1, 0, -2, 2 };
var result = sol.FourSum(arr,0);
for(int i = 0; i < result.Count; i++)
{
    Console.WriteLine(result[i]);
}
using leetcode34;

Solution sol = new Solution();

int[] array = new int[] { 5, 7, 7, 8, 8, 10 };
int[] result = sol.SearchRange(array,8);

for(int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
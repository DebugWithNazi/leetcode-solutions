using leetcode2657;

Solution solution = new Solution();
int[] result = solution.FindThePrefixCommonArray(new int[] { 1, 3, 2, 4 }, new int[] { 3,1,2,4});

for(int i=0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
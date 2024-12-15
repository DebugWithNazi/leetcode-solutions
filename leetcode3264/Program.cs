using leetcode3264;

Solution sol = new Solution();
int[] arr = new int[] { 2, 1, 3, 5, 6 };
int[] final = sol.GetFinalState(arr, 5, 2);

for(int i = 0; i < final.Length; i++)
{
    Console.WriteLine(final[i]);
}
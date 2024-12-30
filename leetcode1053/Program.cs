using leetcode1053;

Solution sol = new Solution();
int[] array = new int[] { 1, 9, 4, 6, 7 };
int[] arr = sol.PrevPermOpt1(array);

for(int i=0; i<arr.Length; i++)
{
    Console.Write(arr[i] + ",");
}

using MergeSort;

Solution sol = new Solution();
int[] array = new int[] { 8, 3, 7, 4, 9, 2 };
sol.MergeSort(array, 0, array.Length - 1);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}

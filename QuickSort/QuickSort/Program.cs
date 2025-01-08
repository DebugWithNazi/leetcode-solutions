using QuickSort;

Solution sol = new Solution();
int[] array = new int[] { 8, 3, 7, 4, 9, 2 };
int[] final = sol.QuickSort(array, 0, array.Length - 1);

for(int i=0; i<final.Length; i++)
{
    Console.Write(final[i] + " ");
}
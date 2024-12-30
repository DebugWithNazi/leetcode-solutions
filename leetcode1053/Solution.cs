using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode1053
{
    public class Solution
    {
        public int[] PrevPermOpt1(int[] arr)
        {
            int n = arr.Length;
            int i = n - 2;

            // Step 1: Find the largest index `i` such that arr[i] > arr[i + 1]
            while (i >= 0 && arr[i] <= arr[i + 1])
            {
                i--;
            }

            // If no such index exists, the array is already the smallest permutation
            if (i < 0)
            {
                return arr;
            }

            // Step 2: Find the largest index `j` such that arr[j] < arr[i]
            int j = n - 1;
            while (arr[j] >= arr[i] || arr[j] == arr[j - 1])
            {
                j--;
            }

            // Step 3: Swap arr[i] and arr[j]
            swap(arr, i, j);

            return arr;
        }

        public void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    //public class Solution
    //{
    //    public int[] PrevPermOpt1(int[] arr)
    //    {
    //        int n = arr.Length;
    //        int i = n - 2;
    //        int j = i+1;
    //        while(j>=0)
    //        {
    //            if(i>0 && arr[i] < arr[j])
    //            {
    //                i--;
    //            }
    //            else
    //            {
    //                swap(arr, i, j);
    //                break;
    //            }
    //            if(i==0)j--;

    //        }
    //        return arr;
    //    }
    //    public void swap(int[] arr, int i, int j)
    //    {
    //        int temp = arr[i];
    //        arr[i] = arr[j];
    //        arr[j] = temp;
    //    }
    //}
}

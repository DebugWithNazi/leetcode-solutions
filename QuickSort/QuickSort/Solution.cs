using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class Solution
    {
        public int[] QuickSort(int[] array,int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = array[left];
            while (i <= j)
            {
                while (array[i] < pivot)
                {
                    i++;
                }
                while (array[j] > pivot)
                {
                    j--;
                }
                if (i <= j)
                {
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                QuickSort(array, left, j);
            }
            if (i < right)
            {
               
                QuickSort(array, i, right);
            }
            return array;
        }
    }
}

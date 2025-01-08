using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class Solution
    {
        public void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                // Find the middle point
                int mid = left + (right - left) / 2;

                // Recursively sort the left and right halves
                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                // Merge the sorted halves
                Merge(array, left, mid, right);
            }
        }

        /// <summary>
        /// Merges two sorted subarrays into a single sorted subarray.
        /// </summary>
        public void Merge(int[] array, int left, int mid, int right)
        {
            // Sizes of the two subarrays
            int n1 = mid - left + 1;
            int n2 = right - mid;

            // Temporary arrays to hold data
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            // Copy data to the temporary arrays
            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[mid + 1 + j];

            // Merge the temporary arrays back into the original array
            int iLeft = 0, jRight = 0;
            int k = left;

            while (iLeft < n1 && jRight < n2)
            {
                if (leftArray[iLeft] <= rightArray[jRight])
                {
                    array[k] = leftArray[iLeft];
                    iLeft++;
                }
                else
                {
                    array[k] = rightArray[jRight];
                    jRight++;
                }
                k++;
            }

            // Copy remaining elements of leftArray, if any
            while (iLeft < n1)
            {
                array[k] = leftArray[iLeft];
                iLeft++;
                k++;
            }

            // Copy remaining elements of rightArray, if any
            while (jRight < n2)
            {
                array[k] = rightArray[jRight];
                jRight++;
                k++;
            }
        }
    }
}

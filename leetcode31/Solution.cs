using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode31
{
    public class Solution
    {
        public void NextPermutation(int[] nums)
        {
            int n = nums.Length;
            int i = n - 2;

            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }

            if (i >= 0)
            {
                int j = n - 1;
                while (nums[i] >= nums[j])
                {
                    j--;
                }
                Swap(nums, i, j);
            }
            Reverse(nums, i + 1, n - 1);
        }
        public void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
        public void Reverse(int[] nums, int i, int j)
        {
            int left = i;
            int right = j;
            while (left < right)
            {
                int temp = nums[left];
                nums[left] = nums[right];
                nums[right] = temp;
                left = left + 1;
                right = right - 1;
            }
        }
    }
}
        //public class Solution
        //{
        //    SortedDictionary<long, List<long>> dict = new SortedDictionary<long, List<long>>();
        //    public void NextPermutation(int[] nums)
        //    {
        //        // Parse the number as long to handle larger numbers
        //        long number = long.Parse(string.Concat(nums));
        //        Array.Sort(nums);
        //        int[] duplicate = (int[])nums.Clone(); // Use Clone to create a proper copy of nums

        //        Permute(nums, 0);
        //        List<long> keys = new List<long>(dict.Keys);
        //        var currentIndex = keys.IndexOf(number);

        //        if (currentIndex >= 0 && currentIndex < dict.Count - 1)
        //        {
        //            long nextKey = keys[currentIndex + 1];
        //            var finalList = dict[nextKey];

        //            for (int i = 0; i < finalList.Count; i++)
        //            {
        //                nums[i] = (int)finalList[i]; // Convert long to int while updating nums
        //            }
        //        }
        //        else if (currentIndex == dict.Count - 1)
        //        {
        //            for (int i = 0; i < duplicate.Length; i++)
        //            {
        //                nums[i] = duplicate[i];
        //            }
        //        }
        //    }
        //    public void Permute(int[] nums, int start)
        //    {
        //        if (start >= nums.Length)
        //        {
        //            // Use long for the dictionary key
        //            long number = long.Parse(string.Concat(nums));
        //            if (!dict.ContainsKey(number))
        //            {
        //                dict.Add(number, nums.Select(n => (long)n).ToList()); // Convert int to long for storage
        //            }
        //            return;
        //        }
        //        for (int i = start; i < nums.Length; i++)
        //        {
        //            Swap(nums, start, i);
        //            Permute(nums, start + 1);
        //            Swap(nums, start, i);
        //        }
        //    }

        //    public void Swap(int[] nums, int start, int i)
        //    {
        //        int temp = nums[start];
        //        nums[start] = nums[i];
        //        nums[i] = temp;
        //    }
        //}


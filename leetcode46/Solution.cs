using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode46
{
    public class Solution
    {
        List<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Permute(nums, 0, result);
            return result;
        }
        public void Permute(int[] nums, int start, List<IList<int>> final)
        {
            if (start >= nums.Length)
            {
                if (!result.Any(r => r.SequenceEqual(nums)))
                    result.Add(new List<int>(nums));
                return;
            }
            for (int i = start; i < nums.Length; i++)
            {
                swap(nums, start, i);
                Permute(nums, start + 1, result);
                swap(nums, start, i);
            }
        }
        public void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

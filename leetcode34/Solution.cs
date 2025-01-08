using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode34
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[2] { -1, -1 };

            // Find the first occurrence
            int left = 0, right = nums.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] >= target)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            if (left < nums.Length && nums[left] == target)
            {
                result[0] = left;
            }
            else
            {
                return result; // Target not found
            }

            // Find the last occurrence
            right = nums.Length - 1; // Reset right pointer
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (nums[mid] <= target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            result[1] = right;

            return result;
        }
    }
}

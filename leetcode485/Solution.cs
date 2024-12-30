using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode485
{
    public class Solution
    {
        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int sum = 0, maxSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    sum++;
                    maxSum = Math.Max(maxSum, sum);
                }
                else
                {
                    sum = 0;
                }
            }
            return maxSum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode3264
{
    public class Solution
    {
        List<int> finalArray = new List<int>();
        public int[] GetFinalState(int[] nums, int k, int multiplier)
        {
            while (k > 0)
            {
                int value = nums.Min();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == value)
                    {
                        nums[i] = value * multiplier;
                        break;
                    }
                }
                k--;
            }
            return nums;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode55
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            int maxReach = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > maxReach)
                {
                    return false;
                }
                maxReach = Math.Max(maxReach, i + nums[i]);
                if (maxReach >= nums.Length - 1)
                {
                    return true;
                }
            }
            return true;
        }
    }
}

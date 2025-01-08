using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode33
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            for(int i=0; i< nums.Length; i++)
            {
                if(target == nums[i])
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

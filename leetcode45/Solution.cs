using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode45
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            int minReach = 0; 
            int lastJumpedPos = 0; 
            int jumps = 0; 

            for (int i = 0; i < nums.Length - 1; i++)
            {
                minReach = Math.Max(minReach, i + nums[i]);

                if (i == lastJumpedPos)
                {
                    jumps++; 
                    lastJumpedPos = minReach; 

                    if (lastJumpedPos >= nums.Length - 1)
                    {
                        break;
                    }
                }
            }
            return jumps;
        }
    }

    //    public int Jump(int[] nums)
    //    {
    //        int minReach = 0,count=0; 
    //        if(nums.Length == 1)
    //        {
    //            return 0;
    //        }
    //        for(int i = 0; i < nums.Length; i++)
    //        {
    //            minReach = Math.Max(minReach, i + nums[i]);
    //            i = minReach ;
    //            count++;
    //            if(minReach >= nums.Length - 1)
    //            {
    //                return count;
    //            }
    //        }
    //        return count;
    //    }
    //}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2932
{
    public class Solution
    {
        int max = int.MinValue;
        public int MaximumStrongPairXor(int[] nums)
        {
            for(int i=0; i<nums.Length; i++)
            {
                for(int j=i; j<nums.Length; j++)
                {
                    int x = nums[i];
                    int y = nums[j];
                    if(Math.Abs(x-y) <= Math.Min(x, y))
                    {
                        int xor = x ^ y;
                        max = Math.Max(max, xor);
                    }
                }
            }
            return max;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode303
{
    public class NumArray
    {
        int[] array;
        
        public NumArray(int[] nums)
        {
            array = nums;
        }

        public int SumRange(int left, int right)
        {
            int sum = 0;
            for (int i = left; i < right; i++) 
            {
                sum = sum + array[i];
            }
            return sum;
        }
    }
}

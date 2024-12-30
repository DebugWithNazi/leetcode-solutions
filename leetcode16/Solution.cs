using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode16
{
    public class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            Array.Sort(nums);
            var closestSum = int.MaxValue;

            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int left = i+1; int right = nums.Length - 1;
                while (left < right)
                {
                    var currentSum = nums[i] + nums[left] + nums[right];
                    if(Math.Abs(currentSum - target) < Math.Abs(closestSum - target))
                    {
                        closestSum = currentSum;
                    }
                    else if(currentSum < target)
                    {
                        left++;
                    }
                    else if(currentSum > target)
                    {
                        right--;
                    }
                    else
                    {
                        return target;
                    }
                }

            }
            return closestSum;
        }
    }
}

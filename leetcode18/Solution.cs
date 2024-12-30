using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace leetcode18
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            var result = new List<IList<int>>();
            Array.Sort(nums);
            int i = 0, next = 0, left = next + 1, right = nums.Length - 1,
                currentSum=0;
            for (int j = 0; j < nums.Length; j++)
            {
                i = j;
                next = i + 1; left = next + 1; right = nums.Length-1;
                while (left < right)
                {
                    if (nums[i] < nums[next] && nums[next] < nums[left] && nums[left] < nums[right])
                    {
                        currentSum = nums[i] + nums[next] + nums[left] + nums[right];
                        if (currentSum == target)
                        {
                            result.Add(new List<int>() { nums[i], nums[next], nums[left], nums[right] });
                        }
                    }

                     left = left + 1; right = right - 1;
                }
            }
            return result;
        }
    }
}

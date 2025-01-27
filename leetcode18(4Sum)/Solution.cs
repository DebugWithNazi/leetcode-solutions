﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode18_4Sum_
{
    public class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            IList<IList<int>> list = new List<IList<int>>();

            int n = nums.Length;
            for (int i = 0; i < n - 3; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                {
                    continue;
                }
                for (int j = i + 1; j < n - 2; j++)
                {
                    if(j > i+1 && nums[j] == nums[j - 1])
                    {
                        continue;
                    }

                    int left = j + 1;
                    int right = n - 1;
                    while(left < right)
                    {
                        long sum = (long)nums[i] + nums[j] + nums[left] + nums[right];
                        if(sum == target)
                        {
                            list.Add(new List<int>() { nums[i] , nums[j] , nums[left] , nums[right] });

                            while (left < right && nums[left] == nums[left + 1])
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right - 1])
                            {
                                right--;
                            }
                            left++;
                            right--;
                        }
                        else if (sum < target)
                        {
                            left++;
                        }
                        else
                        {
                            right--;
                        }
                    }
                }

            }
            return list;

        }
    }
}

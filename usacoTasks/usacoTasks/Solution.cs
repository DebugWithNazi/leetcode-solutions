using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace usacoTask1
{
    public class Solution
    {
        public int Distinct(int[] nums)
        {
            Array.Sort(nums);
            int RepeateNum = 0;
            int maxValue = 0;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                while (i < nums.Length - 1 && nums[i] == nums[i++])
                {
                    RepeateNum++;
                    i++;
                }
                maxValue = Math.Max(maxValue, RepeateNum);
                dict.Add(maxValue, i--);
                RepeateNum = 0;
            }
            return dict.OrderByDescending(x=>x.Value).First().Key;
        }
    }
}

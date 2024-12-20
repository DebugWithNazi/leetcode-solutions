using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode120
{
    public class Solution
    {
        int minValue = int.MaxValue,sum=0, newOne=0;
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            for (int i = 0; i < triangle.Count; i++)
            {
                for(int j=newOne; j<triangle[i].Count; j++)
                {
                    minValue = Math.Min(triangle[i][j], minValue);
                }
                newOne = i;
                sum += minValue;
                minValue = int.MaxValue;
            }
            return sum;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode264
{
    public class Solution
    {
        public int NthUglyNumber(int n)
        {
            int value = 0, count = 0 ;
            for(int i = 1; count <= n; i++)
            {
                value = i;
                if(i%2 ==0 || i%3==0 || i%5 == 0)
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            return value;
        }
    }
}

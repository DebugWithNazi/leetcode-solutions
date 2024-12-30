using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode455
{
    public class Solution
    {
        public int FindContentChildren(int[] g, int[] s)
        {
            Array.Sort(g);
            Array.Sort(s);
            int i = 0, j = 0; 
            while(i< g.Length && j< s.Length)
            {
                if (s[j] >= g[i])
                {
                    i++;
                }
                j++;
            }
            return i;
        }
    }
}

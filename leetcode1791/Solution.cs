using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode1791
{
    public class Solution
    {
        public int FindCenter(int[][] edges)
        {
            if(edges.Length == 0) return 0;
            int max = edges.SelectMany(edge => edge).Max();
            int[] counter = new int[max+1];
            foreach(var edge in edges)
            {
                int a = edge[0];
                int b = edge[1];
                counter[a]++;
                counter[b]++;
            }
            for(int i=0; i<=counter.Length; i++)
            {
                if (counter[i] == max -1)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

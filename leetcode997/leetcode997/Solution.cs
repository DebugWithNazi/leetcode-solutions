using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode997
{
    public class Solution
    {
        public int FindJudge(int n, int[][] trust)
        {
            if(n == 1 && trust.Length == 0)
            {
                return 1;
            }
            int[] counter = new int[n+1];

            foreach(var pair in trust)
            {
                int a = pair[0];
                int b = pair[1];

                counter[a]--;
                counter[b]++;
            }
            for(int i = 0; i <= n; i++)
            {
                if (counter[i] == n - 1)
                {
                    return i;
                }
            }
            return -1;
        }

    }
}

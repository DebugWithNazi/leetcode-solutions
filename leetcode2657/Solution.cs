using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2657
{
    public class Solution
    {
        public int[] FindThePrefixCommonArray(int[] A, int[] B)
        {
            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> result = new List<int>();

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    list1.Add(A[j]);
                    list2.Add(B[j]);
                }
                result.Add(list1.Intersect(list2).Count());
                list1.Clear();
                list2.Clear();
            }
            return result.ToArray();
        }
    }
}

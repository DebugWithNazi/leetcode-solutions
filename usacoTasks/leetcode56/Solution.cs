using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode56
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            Array.Sort(intervals,(a,b) => a[0].CompareTo(b[0]));
            List<int[]> merged = new List<int[]> ();

            foreach(var interval in intervals)
            {
                if(merged.Count == 0 || merged[^1][1] < interval[0])
                {
                    merged.Add(interval);
                }
                else
                {
                    merged[^1][1] = Math.Max(merged[^1][1], interval[1]);
                }
            }
            return merged.ToArray();
        }
        //public int[][] Merge(int[][] intervals)
        //{
        //    Dictionary<int, int> dict = new Dictionary<int, int>();
        //    List<List<int>> finalArray = new List<List<int>>();
        //    Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        //    for (int i = 0; i < intervals.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            for (int j = intervals[i][0]; j <= intervals[i][1]; j++)
        //            {
        //                dict.Add(j, j);
        //            }
        //        }
        //        else if (i > 0 && dict.ContainsKey(intervals[i][0]))
        //        {
        //            for (int j = intervals[i][0]; j <= intervals[i][1]; j++)
        //            {
        //                if (!dict.ContainsKey(j))
        //                    dict.Add(j, j);
        //            }
        //        }
        //        else
        //        {
        //            finalArray.Add(new List<int> { dict.Keys.Min(), dict.Keys.Max() });

        //            dict.Clear();

        //            for (int j = intervals[i][0]; j <= intervals[i][1]; j++)
        //            {
        //                dict.Add(j, j);
        //            }
        //        }
        //    }
        //    finalArray.Add(new List<int> { dict.Keys.Min(), dict.Keys.Max() });

        //    int[][] jaggedArray = finalArray.Select(row => row.ToArray()).ToArray();
        //    return jaggedArray;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2357
{
    public class Solution
    {
        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();
        public int MinimumOperations(int[] nums)
        {
            int count = 0;
            for(int i=0; i<nums.Length; i++)
            {
                minHeap.Enqueue(nums[i], nums[i]);
            }

            while(minHeap.Count > 0)
            {
                int min = minHeap.Dequeue();
                if(min == 0)
                {
                    continue;
                }
                else
                {
                   List<int> temp = new List<int>();
                    while(minHeap.Count > 0)
                    {
                        int element = minHeap.Dequeue();
                        temp.Add(element-min);
                    }
                    foreach(int i in temp)
                    {
                        minHeap.Enqueue(i,i);
                    }
                    count++;
                }

            }
            return count;
        }
    }
}

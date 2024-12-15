using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode215
{
    public class Solution
    {
        PriorityQueue<int,int> maxHeap = new PriorityQueue<int,int>();
        public int FindKthLargest(int[] nums, int k)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                maxHeap.Enqueue(nums[i], -nums[i]);
            }
            while (k-1 > 0)
            {
                maxHeap.Dequeue();
                k--;
            }
            return maxHeap.Peek();
        }
    }
}

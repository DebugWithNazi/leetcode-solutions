using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2974
{
    public class Solution
    {
        PriorityQueue<int, int> minHeap = new PriorityQueue<int, int>();
        
        public int[] NumberGame(int[] nums)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                minHeap.Enqueue(nums[i], nums[i]);
            }

           while(minHeap.Count > 0)
            {
                int alice = minHeap.Dequeue();
                int bob = minHeap.Dequeue();
                list.Add(bob);
                list.Add(alice);
            }
           return list.ToArray();
        }
    }
}

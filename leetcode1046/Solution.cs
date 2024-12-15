using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode1046
{
    public class Solution
    {
        // choose haviest two stones 
        // x< = y
        // if (x==y) both dequeue
        // if (x!=y) x dequeue and y-x
        int first = 0, second = 0;
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        public int LastStoneWeight(int[] stones)
        {
            for (int i = 0; i < stones.Length; i++)
            {
                maxHeap.Enqueue(stones[i], -stones[i]);
            }
            while (maxHeap.Count - 1 > 0)
            {
                second = maxHeap.Dequeue();
                first = maxHeap.Dequeue();
                if (first == second)
                {
                    continue;
                }
                else if (first != second)
                {
                    second = second - first;
                    maxHeap.Enqueue(second, -second);
                }
            }
            if (maxHeap.Count > 0)
            {
                return maxHeap.Dequeue();
            }
            else
            {
                return 0;
            }
        }
    }
}

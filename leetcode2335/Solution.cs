using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode2335
{
    public class Solution
    {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        int count = 0;
        public int FillCups(int[] amount)
        {
            for (int i = 0; i < amount.Length; i++)
            {
                if (amount[i] != 0)
                maxHeap.Enqueue(amount[i], -amount[i]);
            }

            while (maxHeap.Count > 0)
            {
                if (maxHeap.Count >= 2)
                {
                    int first = maxHeap.Dequeue();
                    int second = maxHeap.Dequeue();
                    if (first != 0)
                    {
                        first = first - 1;
                        if (first != 0)
                            maxHeap.Enqueue(first, -first);
                    }
                    if (second != 0)
                    {
                        second = second - 1;
                        if (second != 0)
                            maxHeap.Enqueue(second, -second);
                    }
                }
                else
                {
                    int val = maxHeap.Dequeue();
                    val = val - 1;
                    if (val != 0)
                        maxHeap.Enqueue(val, -val);
                }
                count++;
            }
            return count;
        }
    }
}

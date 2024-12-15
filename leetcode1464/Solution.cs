using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode1464
{
    public class Solution
    {
        PriorityQueue<int, int> maxHeap = new PriorityQueue<int, int>();
        public int MaxProduct(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                int j = i + 1;
                while (j < nums.Length)
                {
                    int product = (nums[i] - 1) * (nums[j] - 1);
                    maxHeap.Enqueue(product, -product);
                    j++;
                }
                
            }
            return maxHeap.Peek();
        }
    }
}


using System.Runtime.ExceptionServices;

namespace Leetcode703
{
    public class KthLargest
    {
        int kthValue;
        PriorityQueue<int, int> minHeap;
        public KthLargest(int k, int[] nums)
        {
            this.kthValue = k;
            this.minHeap = new PriorityQueue<int, int>();
            foreach(int num in nums)
            {
                Add(num);
            }
        }

        public int Add(int val)
        {
            minHeap.Enqueue(val,val);

            if(minHeap.Count > kthValue)
            {
                minHeap.Dequeue();
            }

            return minHeap.Peek();
        }
    }
    //public class KthLargest
    //{
    //    int nums = 0,i=0;
    //    public Dictionary<int,int> dict = new Dictionary<int,int>();
    //    public KthLargest(int k, int[] nums)
    //    {
    //        for(; i < nums.Length; i++)
    //        {
    //            dict.Add(i, nums[i]);
    //        }
    //        this.nums = k;
    //    }

    //    public int Add(int val)
    //    {
    //        dict.Add(i,val); i++;
    //        int kthLargest = dict.Values.OrderByDescending(x=>x)
    //                             .Skip(nums-1).First();
    //        return kthLargest;            
    //    }
    //}
}

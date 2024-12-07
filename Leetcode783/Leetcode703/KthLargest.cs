
namespace Leetcode703
{
    public class KthLargest
    {
        int nums = 0,i=0;
        public Dictionary<int,int> dict = new Dictionary<int,int>();
        public KthLargest(int k, int[] nums)
        {
            for(; i < nums.Length; i++)
            {
                dict.Add(i, nums[i]);
            }
            this.nums = k;
        }

        public int Add(int val)
        {
            dict.Add(i,val); i++;
            int kthLargest = dict.Values.OrderByDescending(x=>x)
                                 .Skip(nums-1).First();
            return kthLargest;            
        }
    }
}


namespace leetcode349
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> count = new Dictionary<int, int>();
            List<int> result = new List<int>();
            foreach (var num in nums1)
            {
                if (!count.ContainsKey(num))
                {
                    count[num] = 0;
                }
                count[num]++;
            }

            foreach (var num in nums2)
            {
                if (count.ContainsKey(num) && count[num] > 0)
                {
                    result.Add(num);
                    count[num]--;
                }
            }
            return result.ToArray();    
        }
    }
}

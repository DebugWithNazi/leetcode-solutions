using leetcode349;

Solution solution = new Solution();
int[] nums1 = new int[] { 4, 9, 5 };
int[] nums2 = new int[] { 9, 4, 9, 8, 4 };
int[] arr = solution.Intersection(nums1,nums2);

for(int i=0; i<arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}
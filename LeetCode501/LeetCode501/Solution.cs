using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode501
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        public void InorderTraversal(TreeNode root)
        {
            if (root != null)
            {
                InorderTraversal(root.left);
                if (dict.ContainsKey(root.val))
                {
                    dict[root.val]++;
                }
                else
                {
                    dict[root.val] = 1;
                }
                InorderTraversal(root.right);
            }
           
        }
        public int[] FindMode(TreeNode root)
        {
            InorderTraversal(root);
            int maxFrequency = dict.Values.Max();

            List<int> modes = dict.Where(x => x.Value == maxFrequency)
                              .Select(x => x.Key).ToList();
            return modes.ToArray();
        }

    }
}

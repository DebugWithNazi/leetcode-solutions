using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode783
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
        public TreeNode Root;
        public int MinDiffInBST(TreeNode root)
        {
            InorderTraversal(root);
            return map.Values.Min();

        }
        int current, prev, diff, i = 0, temp = 0, count = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        public void InorderTraversal(TreeNode root)
        {
            if (root != null)
            {
                InorderTraversal(root.left);
                current = root.val;
                if (current >= 0)
                {
                    prev = temp;
                    temp = current;
                    if (count > 0)
                    {
                        diff = Math.Abs(current) - Math.Abs(prev);
                        map.Add(i, diff); i++;
                    }
                    count++;
                }
                InorderTraversal(root.right);
            }

        }

    }
}


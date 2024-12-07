using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace leetcode897
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
        TreeNode final = new TreeNode(0);
        TreeNode current;
        public TreeNode IncreasingBST(TreeNode root)
        {
            current = final;
            Insertion(root);
            return final.right;
        }
        public void Insertion(TreeNode root) 
        {
            if (root != null)
            {
                Insertion(root.left);
                root.left = null;
                current.right = root;
                current = root;
                Insertion(root.right);
            }
        }
        public void PrintTree(TreeNode root)
        {
            while (root != null)
            {
                Console.Write(root.val + " ");
                root = root.right;
            }
        }
    }
}

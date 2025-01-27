using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode114
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
        public void Flatten(TreeNode root)
        {
            if (root == null) return;
            
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0) 
            {
                TreeNode current = stack.Pop();

                if(current.right != null)
                {
                    stack.Push(current.right);
                }

                if(current.left != null)
                {
                    stack.Push(current.left);
                }

                if (stack.Count > 0)
                {
                    current.right = stack.Peek();
                }
                current.left = null;
            }

        }
    }
}

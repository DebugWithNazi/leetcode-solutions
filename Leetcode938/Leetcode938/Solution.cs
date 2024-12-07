using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Leetcode938
{
    public class Solution
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
        int sum = 0;

        public int RangeSumBST(TreeNode root, int low, int high)
        {
            if (root != null)
            {
                RangeSumBST(root.left, low, high);
                if (root.val >= low && root.val <= high)
                {
                    sum = sum + root.val;
                }
                RangeSumBST(root.right, low, high);
            }
            return sum;
        }
        private TreeNode final = new TreeNode(0); // Initialize with a dummy node
        private TreeNode current; // Pointer to track the current node in the new tree

        public TreeNode IncreasingBST(TreeNode root)
        {
            if (current == null)
            {
                current = final; // Ensure the current pointer starts at the dummy node
            }

            if (root != null)
            {
                root.left = IncreasingBST(root.left); // Traverse and modify the left subtree
                //Console.WriteLine(root.left.val);
                //root.left = null; // Set left child to null
                //Console.WriteLine(root.right.val);
                current.right = root; // Attach the current node to the right
                //Console.WriteLine(root.right.val);
                current = root; // Move the pointer to the current node
                Console.WriteLine(current.val);

                root.right = IncreasingBST(root.right); // Traverse and modify the right subtree
            }
            return final.right; // Return the right child of the dummy node as the new root
        }


        public void LevelOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode current = queue.Dequeue();
                Console.Write(current.val + " ");

                if (current.left != null)
                {
                    queue.Enqueue(current.left);
                }
                if (current.right != null)
                {
                    queue.Enqueue(current.right);
                }
            }
        }
    }
}

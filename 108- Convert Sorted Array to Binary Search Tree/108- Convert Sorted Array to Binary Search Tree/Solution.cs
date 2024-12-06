using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
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
        public TreeNode Root;
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return Root = Bst(nums, 0, nums.Length - 1);
        }
        public TreeNode Bst(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            int mid = left + (right - left) / 2;
            TreeNode node = new TreeNode(mid);

            node.left = Bst(nums, left, mid - 1);
            node.right = Bst(nums, mid + 1,right); 

            return node;
        }

        public void PrintLevelOrder(TreeNode? node)
        {
            if(node == null) {  return; }
            Queue<TreeNode?> queue = new Queue<TreeNode?>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                TreeNode? current = queue.Dequeue();
                if(current == null)
                {
                    Console.Write("null ");
                    continue;
                }
                Console.Write(current.val + " ");
                queue.Enqueue(current.left);
                queue.Enqueue(current.right);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode653
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
        List<int> list = new List<int>();
        int sum = 0; 
        public bool FindTarget(TreeNode root, int k)
        {
            List<int> finalList = InOrderTraversal(root);
            for(int i=0; i<finalList.Count; i++)
            {
                for(int j=0; j<finalList.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    else
                    {
                        sum = finalList[i] + finalList[j];
                        if(sum == k)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public List<int> InOrderTraversal(TreeNode root)
        {
            if(root != null)
            {
                InOrderTraversal(root.left);
                list.Add(root.val);
                InOrderTraversal(root.right);
            }
            return list;
        }
    }
}

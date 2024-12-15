using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace leetcode23
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }

    }
    public class Solution
    {
        public ListNode finalList = new ListNode();
        public ListNode current;
        public TreeNode Root;
        public ListNode MergeKLists(ListNode[] lists)
        {
           foreach(var head in lists)
            {
                var currentList = head;
                while(currentList != null)
                {
                    Insert(currentList.val);
                    currentList = currentList.next;
                }
            }
            InOrderTraversal();
            return finalList.next;
        }
        
        public void Insert(int val)
        {
           Root = InsertNode(Root, val);
        }
        public TreeNode InsertNode(TreeNode node, int value)
        {
            if (node == null)
            {
                 return new TreeNode(value);
            }
            if (value < node.Value)
            {
                node.Left =InsertNode(node.Left, value);
            }
            else
            {
                node.Right =InsertNode(node.Right, value);
            }
            return node;
        }
        

        public void InOrderTraversal()
        {
            current = finalList;
            InOrder(Root);
        }
        public void InOrder(TreeNode node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                current.next = new ListNode(node.Value); 
                current = current.next;
                InOrder(node.Right);
            }
        }
    }
}

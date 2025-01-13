using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class TreeNode
    {
        public int value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int _value)
        {
            value = _value;
            left = null;
            right = null;
        }
    }
    public class BinarySearchTree
    {
        public TreeNode Root;
        public BinarySearchTree()
        {
            Root = null;
        }
        public TreeNode Insert(TreeNode node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value);
            }
            if (value < node.value)
            {
                node.left = Insert(node.left, value);
            }
            else if (value > node.value)
            {
                node.right = Insert(node.right, value);
            }
            return node;
        }

        public bool Search(TreeNode node, int value)
        {
            if (node == null)
            {
                return false;
            }

            if(value == node.value  )
            {
                return true;
            }
           
            else if (value < node.value)
            {
                 return Search(node.left, value);
            }
            else 
            {
                return Search(node.right, value);
            }
        }

        public TreeNode Delete(TreeNode node, int value)
        {
            if(node == null)
            {
                return null;
            }

            if(value < node.value)
            {
                node.left = Delete(node.left, value);
            }
            else if(value > node.value)
            {
                node.right = Delete(node.right, value);
            }
            else
            {
                if(node.left == null && node.right == null)
                {
                    return null;
                }
                else if(node.left == null)
                {
                    return node.right;
                }
                else if(node.right == null)
                {
                    return node.left;
                }

                var successor = FindMin(node.right);
                node.value = successor.value;
                node.right = Delete(node.right, successor.value);
            }
            return node;
        }

        public TreeNode FindMin(TreeNode node)
        {
            if(node.left == null)
            {
                return node;
            }
            return FindMin(node.left);
        }

        public void Preorder(TreeNode node )
        {
            if (node == null) { return; }
            Console.Write(node.value + " ");
            Preorder(node.left);
            Preorder(node.right);
        }

        public void Postorder(TreeNode node)
        {
            if(node == null) { return; }
            Postorder(node.left);
            Postorder(node.right);
            Console.Write(node.value + " ");
        }
        public void Inorder(TreeNode node)
        {
            if (node == null) { return; }
            Inorder(node.left);
            Console.Write(node.value + " ");
            Inorder(node.right);
        }
    }
}

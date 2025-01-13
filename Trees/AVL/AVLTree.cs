using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVL
{
    class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;
        public int Height;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
            Height = 1; // New node is initially added at height 1
        }
    }

    class AVLTree
    {
        public TreeNode Root;

        public AVLTree()
        {
            Root = null;
        }

        // Get the height of a node
        private int Height(TreeNode node)
        {
            return node == null ? 0 : node.Height;
        }

        // Get the balance factor of a node
        private int BalanceFactor(TreeNode node)
        {
            return node == null ? 0 : Height(node.Left) - Height(node.Right);
        }

        // Perform a right rotation
        private TreeNode RightRotate(TreeNode y)
        {
            TreeNode x = y.Left;
            TreeNode T2 = x.Right;

            // Perform rotation
            x.Right = y;
            y.Left = T2;

            // Update heights
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;

            // Return new root
            return x;
        }

        // Perform a left rotation
        private TreeNode LeftRotate(TreeNode x)
        {
            TreeNode y = x.Right;
            TreeNode T2 = y.Left;

            // Perform rotation
            y.Left = x;
            x.Right = T2;

            // Update heights
            x.Height = Math.Max(Height(x.Left), Height(x.Right)) + 1;
            y.Height = Math.Max(Height(y.Left), Height(y.Right)) + 1;

            // Return new root
            return y;
        }

        // Insert a value into the AVL tree
        public TreeNode Insert(TreeNode node, int value)
        {
            if (node == null)
            {
                return new TreeNode(value); // Create a new node
            }

            if (value < node.Value)
            {
                node.Left = Insert(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = Insert(node.Right, value);
            }
            else
            {
                return node; // Duplicate values are not allowed
            }

            // Update height of the current node
            node.Height = 1 + Math.Max(Height(node.Left), Height(node.Right));

            // Check the balance factor
            int balance = BalanceFactor(node);

            // Perform rotations if the node is unbalanced
            // Left-Left (LL) Case
            if (balance > 1 && value < node.Left.Value)
            {
                return RightRotate(node);
            }

            // Right-Right (RR) Case
            if (balance < -1 && value > node.Right.Value)
            {
                return LeftRotate(node);
            }

            // Left-Right (LR) Case
            if (balance > 1 && value > node.Left.Value)
            {
                node.Left = LeftRotate(node.Left);
                return RightRotate(node);
            }

            // Right-Left (RL) Case
            if (balance < -1 && value < node.Right.Value)
            {
                node.Right = RightRotate(node.Right);
                return LeftRotate(node);
            }

            return node; // Return the unchanged node
        }

        // Inorder traversal of the AVL tree
        public void Inorder(TreeNode node)
        {
            if (node == null) return;

            Inorder(node.Left);
            Console.Write(node.Value + " ");
            Inorder(node.Right);
        }
    }



}

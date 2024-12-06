// See https://aka.ms/new-console-template for more information
using LeetCode501;

Console.WriteLine("Hello, World!");
Solution sol = new Solution();
TreeNode root = new TreeNode(1);
root.right = new TreeNode(2);
root.right.right = new TreeNode(2);

// Pass root to a function to perform an operation, e.g., inorder traversal
sol.FindMode(root);
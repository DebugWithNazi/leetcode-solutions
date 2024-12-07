using Leetcode938;
using static Leetcode938.Solution;

Solution sol = new Solution();
TreeNode node = new TreeNode(5);
node.left = new TreeNode(3);
node.right = new TreeNode(6);
node.left.left = new TreeNode(2);
node.left.right = new TreeNode(4);
node.left.left.left = new TreeNode(1);
node.left.right.right = new TreeNode(8);
node.left.right.right.left = new TreeNode(7);
node.left.right.right.right = new TreeNode(9);


int sum = sol.RangeSumBST(node, 7,15);
Console.WriteLine(sum);
TreeNode node1 = sol.IncreasingBST(node);
sol.LevelOrderTraversal(node1);



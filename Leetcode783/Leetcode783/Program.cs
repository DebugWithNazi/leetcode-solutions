using Leetcode783;

Solution sol = new Solution();
TreeNode node = new TreeNode(0);
//node.left = new TreeNode(1);
node.right = new TreeNode(2236);
node.right.left = new TreeNode(1277);
node.right.right = new TreeNode(2776);
node.right.left.left = new TreeNode(519);
//node.right.left = new TreeNode(12);
//node.right.right = new TreeNode(49);
//node.left.left.left = new TreeNode(1);
//node.left.right.right = new TreeNode(8);
//node.left.right.right.left = new TreeNode(7);
//node.left.right.right.right = new TreeNode(9);

int sum = sol.MinDiffInBST(node);
Console.WriteLine(sum);

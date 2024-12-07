using leetcode653;

Solution sol = new Solution();
TreeNode node = new TreeNode(5);
node.left = new TreeNode(3);
node.right = new TreeNode(6);
node.left.left = new TreeNode(2);
node.left.right = new TreeNode(4);
node.right.right = new TreeNode(7);
//node.right.left = new TreeNode(12);
//node.right.right = new TreeNode(49);
//node.left.left.left = new TreeNode(1);
//node.left.right.right = new TreeNode(8);
//node.left.right.right.left = new TreeNode(7);
//node.left.right.right.right = new TreeNode(9);

bool result = sol.FindTarget(node,9);
Console.WriteLine(result);
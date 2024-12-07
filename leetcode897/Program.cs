using leetcode897;

TreeNode root = new TreeNode(5,
            new TreeNode(3,
                new TreeNode(2, new TreeNode(1)),
                new TreeNode(4)),
            new TreeNode(6, null,
                new TreeNode(8,
                    new TreeNode(7),
                    new TreeNode(9)))
        );

Solution solution = new Solution();
TreeNode result = solution.IncreasingBST(root);

// Print the result tree
solution.PrintTree(result);

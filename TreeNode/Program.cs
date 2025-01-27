
class TreeNode
{
    public int Value;
    public TreeNode Left, Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = Right = null;
    }
}

class BinaryTree
{
    public TreeNode Root;
    public BinaryTree()
    {
        Root = null;
    }
    public TreeNode FindLCA(TreeNode root, TreeNode node1, TreeNode node2)
    {
        if(root == null || root == node1 || root == node2)
        {
            return root;
        }

        root.Left = FindLCA(root.Left, node1, node2);
        root.Right = FindLCA(root.Right, node1, node2);

        if (root.Left != null && root.Right != null)
        {
            return root;
        }

        return root.Left != null ? root.Left : root.Right;

    }

}
class Program
{
    static void Main()
    {
        BinaryTree tree = new BinaryTree();
        tree.Root = new TreeNode(3);
        tree.Root.Left = new TreeNode(5);
        tree.Root.Right = new TreeNode(1);
        tree.Root.Left.Left = new TreeNode(6);
        tree.Root.Left.Right = new TreeNode(2);
        tree.Root.Right.Left = new TreeNode(0);
        tree.Root.Right.Right = new TreeNode(8);
        tree.Root.Left.Right.Left = new TreeNode(7);
        tree.Root.Left.Right.Right = new TreeNode(4);

        TreeNode node1 = tree.Root.Left;  // Node 5
        TreeNode node2 = tree.Root.Left.Right.Right; // Node 4

        TreeNode lca = tree.FindLCA(tree.Root, node1, node2);
        Console.WriteLine("LCA of " + node1.Value + " and " + node2.Value + " is: " + lca.Value);
    }
}
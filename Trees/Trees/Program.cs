using Trees;

BinarySearchTree bst = new BinarySearchTree();

// Insert values into the BST
bst.Root = bst.Insert(bst.Root, 10);
bst.Insert(bst.Root, 5);
bst.Insert(bst.Root, 15);
bst.Insert(bst.Root, 3);
bst.Insert(bst.Root, 7);
bst.Insert(bst.Root, 12);
bst.Insert(bst.Root, 18);

Console.WriteLine("Inorder Traversal (Sorted Order):");
bst.Inorder(bst.Root); // Output: 3 5 7 10 12 15 18

Console.WriteLine("\n\nPreorder Traversal (Root, Left, Right):");
bst.Preorder(bst.Root); // Output: 10 5 3 7 15 12 18

Console.WriteLine("\n\nPostorder Traversal (Left, Right, Root):");
bst.Postorder(bst.Root); // Output: 3 7 5 12 18 15 10

// Search for a value
Console.WriteLine("\n\nSearch for 7:");
Console.WriteLine(bst.Search(bst.Root, 7) ? "Found" : "Not Found"); // Output: Found

Console.WriteLine("\nSearch for 20:");
Console.WriteLine(bst.Search(bst.Root, 20) ? "Found" : "Not Found"); // Output: Not Found

// Delete a value
Console.WriteLine("\nDelete 15:");
bst.Root = bst.Delete(bst.Root, 15);

Console.WriteLine("Inorder Traversal After Deletion:");
bst.Inorder(bst.Root); // Output: 3 5 7 10 12 18
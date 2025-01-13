
using AVL;

AVLTree avl = new AVLTree();

// Insert values into the AVL tree
avl.Root = avl.Insert(avl.Root, 10);
avl.Root = avl.Insert(avl.Root, 20);
avl.Root = avl.Insert(avl.Root, 30);
avl.Root = avl.Insert(avl.Root, 40);
avl.Root = avl.Insert(avl.Root, 50);
avl.Root = avl.Insert(avl.Root, 25);

// Perform an inorder traversal
Console.WriteLine("Inorder Traversal of the AVL Tree:");
avl.Inorder(avl.Root); // Output: 10 20 25 30 40 50

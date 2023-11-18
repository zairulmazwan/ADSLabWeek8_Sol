// Part 1

// int [] data = {57,20,68,15,21,65,80,60,67,70,85};


// BinaryTree bt = new BinaryTree();
// bt.createBinaryTree(data);


// Console.WriteLine("==Pre-order==");
// bt.traversePreOrder(bt.root);
// Console.WriteLine("\n==Level Order==");
// bt.traverseLevelOrder(bt.root);
// Console.WriteLine("\n==Post Order==");
// bt.traversePostOrder(bt.root);


//Part 2
// Console.WriteLine("===Binary Heap===");

// Heap bh = new Heap();

// bh.insert(47);
// bh.insert(57);
// bh.insert(23);
// bh.insert(42);
// bh.insert(31);
// bh.insert(29);
// bh.insert(17);

// Console.WriteLine("Binary Heap : ");
// bh.printHeap();
// Console.WriteLine("Size : ");
// Console.WriteLine("Maximum value from the tree : " + bh.getMax());

// int[] decs = bh.descending();
// Console.WriteLine("Elements in descending order : ");
// bh.printArray(decs);

//Question 4

HeapOrder bh = new HeapOrder();

Order o1 = new Order(8,111,"Sandwich");
Order o2 = new Order(11,113,"Burger");
Order o3 = new Order(4,119,"Coffee");
Order o4 = new Order(7,104,"Mocha");
Order o5 = new Order(3,134,"Noodles");

bh.insert(o1);
bh.insert(o2);
bh.insert(o3);
bh.insert(o4);
bh.insert(o5);

Console.WriteLine("Root: "+bh.getMin().priority);

Order [] asc = bh.ascending();
bh.printArray(asc);



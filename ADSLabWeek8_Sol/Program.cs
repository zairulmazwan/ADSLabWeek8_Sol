// Part 1

int [] data = {57,20,68,15,21,65,80,60,67,70,85};


BinaryTree bt = new BinaryTree();
bt.createBinaryTree(data);


Console.WriteLine("==Pre-order==");
bt.traversePreOrder(bt.root);
Console.WriteLine("\n==Level Order==");
bt.traverseLevelOrder(bt.root);
Console.WriteLine("\n==Post Order==");
bt.traversePostOrder(bt.root);


//Part 2
Console.WriteLine("===Binary Heap===");

Heap bh = new Heap();

bh.insert(47);
bh.insert(57);
bh.insert(23);
bh.insert(42);
bh.insert(31);
bh.insert(29);
bh.insert(17);

Console.WriteLine("Binary Heap : ");
bh.printHeap();
Console.WriteLine("Size : ");
Console.WriteLine("Maximum value from the tree : " + bh.getMax());

int[] decs = bh.descending();
Console.WriteLine("Elements in descending order : ");
bh.printArray(decs);
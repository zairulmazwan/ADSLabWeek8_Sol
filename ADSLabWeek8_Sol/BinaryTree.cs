// import java.util.Enumeration;
// import java.util.Hashtable;
// import java.util.LinkedList;
// import java.util.Queue;

//import Tree.BinaryTree.Node;

public class BinaryTree 
{
    public Node root=null;
    
    private Node addRecursive(Node current, int value) {
        if (current == null) { //set the root if its a new tree
            return new Node(value);
        }

        if (value < current.value) { //otherwise, add the node underneath the existing root
            current.left = addRecursive(current.left, value); //if the node has leafs, then go further to search left leaf
        } else if (value > current.value) {
            current.right = addRecursive(current.right, value);
        } else {
            // value already exists
            Console.WriteLine(current.value);
            return current;
        }
        
        return current;
    }
    
    public void add(int value) {
        //Console.WriteLine(value);
        root = addRecursive(root, value);
    }
    
    public void createBinaryTree(int [] data) {
        
        foreach (int x in data) {
            add(x);
        }
        
    }
    
    public Boolean containsNodeRecursive(Node current, int value) {
        if (current == null) {
            return false;
        } 
        if (value == current.value) {
            return true;
        } 
        return (value < current.value)
            ? containsNodeRecursive(current.left, value)
            : containsNodeRecursive(current.right, value);
    }
    
    public Boolean containsNode(int value) {
        return containsNodeRecursive(root, value);
    }
    
    public void delete(int value) {
        root = deleteRecursive(root, value);
    }

    private Node deleteRecursive(Node current, int value) {
        if (current == null) {
            return null;
        }
        //if the node is to be deleted
        if (value == current.value) {
            // Case 1: no children
            if (current.left == null && current.right == null) {
                return null;
            }

            // Case 2: only 1 child
            if (current.right == null) {
                return current.left;
            }

            if (current.left == null) {
                return current.right;
            }
            
            // Case 3: has 2 both left and right nodes
            int smallestValue = findSmallestValue(current.right);
            current.value = smallestValue;
            current.right = deleteRecursive(current.right, smallestValue);
            return current;
        }
        
        if (value < current.value) {
            current.left = deleteRecursive(current.left, value);
            return current;
        }

        current.right = deleteRecursive(current.right, value);
        return current;
    }
    
    private int findSmallestValue(Node root) {
        return root.left == null ? root.value : findSmallestValue(root.left);
    }
    
    //Depth First Search: Root=>Left=>Right
    public void traversePreOrder(Node node) {
        
        if (node != null)
        {
            visit(node.value);
            traversePreOrder(node.left);
            traversePreOrder(node.right);
        }
    }
    
    
    //Left=>Right=>Node
    public void traversePostOrder(Node node) {
        
        if (node != null)
        {
            traversePostOrder(node.left);
            traversePostOrder(node.right);
            visit(node.value);
        }
    }
    
    //Breadth-First Search: visit all the nodes present at the same level one-by-one from left to right and then move to the next level to visit all the nodes of that level.
    public void traverseLevelOrder(Node node) {

        if (node != null)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while (q.Count != 0)
            {
                Node n = q.Dequeue();
                visit(n.value);

                if (n.left != null)
                {
                    q.Enqueue(n.left);
                }

                if (n.right != null)
                {
                    q.Enqueue(n.right);
                }
            }
        }
    }
    
    private void visit(int value) {
        Console.Write(" " + value);        
    }

}

 public class Node 
 {
    public int value;
    public Node left;
    public Node right;

    public Node(int data) {
        value = data;
        right = null;
        left = null;
    }
}
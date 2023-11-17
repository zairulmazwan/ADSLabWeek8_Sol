
public class HeapOrder {
	
	private const int MAX_SIZE = 10;
    static Order [] heap;
    static int size;
    
    public HeapOrder() {
        heap = new Order[MAX_SIZE];
        size = 0;
    }
    
    //get the index of the parent node
    public static int parent(int i) {
        return (i - 1) / 2;
    }
    
    // get the index of the left child 
    public static int leftChild(int i) {
        return 2*i + 1;
    }
    
    // get the index of the right child 
    public static int rightChild(int i) {
        return 2*i + 2;
    }
    
    // insert the item at the appropriate position
    public void insert(Order data) {
        if (size >= MAX_SIZE) {
            Console.WriteLine("The heap is full. Cannot insert");
            return;
        }

        // first insert the time at the last position of the array 
        // and move it up
        heap[size] = data;
        size = size + 1;


        // move up until the heap property satisfies
        int i = size - 1;
        while (i != 0 && heap[i].priority<heap[HeapOrder.parent(i)].priority) {
            Order temp = heap[i];
            heap[i] = heap[HeapOrder.parent(i)];
            heap[HeapOrder.parent(i)] = temp;
            i = HeapOrder.parent(i);
        }
    }

    public static void minHeapify(int i){
        // find left child node
        int left = HeapOrder.leftChild(i);

        // find right child node
        int right = HeapOrder.rightChild(i);

        // find the largest among 3 nodes
        int smallest = i;

        // check if the left node is larger than the current node
        if (left <= size && heap[left].priority< heap[smallest].priority) {
            smallest = left;
        }

        // check if the right node is larger than the current node 
        // and left node
        if (right <= size && heap[right].priority < heap[smallest].priority) {
            smallest = right;
        }

        // swap the largest node with the current node 
        // and repeat this process until the current node is larger than 
        // the right and the left node
        if (smallest != i) {
            Order temp = heap[i];
            heap[i] = heap[smallest];
            heap[smallest] = temp;
            minHeapify(smallest);
        }
    }


    // returns the  maximum item of the heap
    public Order getMax()
    {
        //write your code here!
        return heap[0];

    }

    public Order getMin()
    {
        //write your code here!
        return heap[0];

    }

    // deletes the max item and return
    public static void deleteNode(int i) {
        //int node = heap[i];

        // replace the first item with the last item
        heap[i] = heap[size - 1];
        size = size - 1;

        // maintain the heap property by heapifying the 
        // first item
        minHeapify(i);
        //return node;
    }
    
    public Order [] ascending() {
    	Order [] res = new Order [size];

        //Write your code here!
        int resSize = res.Length;
        int i = 0;
        while (i<resSize)
        {
            res[i] = heap[0];
            deleteNode(0);
            i++;
        }
    	return res;
    }

    // prints the heap
    public void printHeap() {
        for (int i = 0; i < size; i++) {
            Console.Write("Priority: "+heap[i].priority + " ID: "+heap[i].orderID);
        }
        Console.WriteLine();
    }
    
    public void printArray(Order [] array) {
    	foreach(Order x in array) {
    		Console.WriteLine("Priority: "+x.priority + " ID: "+x.orderID+" Description: "+x.orderDesciption);
    	}
    }

}

public class Order
{
    public int priority;
    public int orderID;
    public string orderDesciption; 
    public Order (int priority, int orderID, string orderDesciption)
    {   
        this.priority = priority;
        this.orderID = orderID;
        this.orderDesciption = orderDesciption;
    }
}
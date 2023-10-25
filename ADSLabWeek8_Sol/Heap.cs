
public class Heap {
	
	private const int MAX_SIZE = 10;
    static int [] heap;
    static int size;
    
    public Heap() {
        heap = new int[MAX_SIZE];
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
    public void insert(int data) {
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
        while (i != 0 && heap[i]>heap[Heap.parent(i)]) {
            int temp = heap[i];
            heap[i] = heap[Heap.parent(i)];
            heap[Heap.parent(i)] = temp;
            i = Heap.parent(i);
        }
    }
    
    // moves the item at position i of array a
    // into its appropriate position
    public static void maxHeapify(int i){
        // find left child node
        int left = Heap.leftChild(i);

        // find right child node
        int right = Heap.rightChild(i);

        // find the largest among 3 nodes
        int largest = i;

        // check if the left node is larger than the current node
        if (left <= size && heap[left] > heap[largest]) {
            largest = left;
        }

        // check if the right node is larger than the current node 
        // and left node
        if (right <= size && heap[right] > heap[largest]) {
            largest = right;
        }

        // swap the largest node with the current node 
        // and repeat this process until the current node is larger than 
        // the right and the left node
        if (largest != i) {
            int temp = heap[i];
            heap[i] = heap[largest];
            heap[largest] = temp;
            maxHeapify(largest);
        }

    }

    // returns the  maximum item of the heap
    public int getMax()
    {
        //write your code here!
        return heap[0];

    }

    // deletes the max item and return
    public static int deleteNode(int i) {
        int node = heap[i];

        // replace the first item with the last item
        heap[i] = heap[size - 1];
        size = size - 1;

        // maintain the heap property by heapifying the 
        // first item
        maxHeapify(i);
        return node;
    }
    
    public int [] descending() {
    	int [] res = new int [size];

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
            Console.Write(heap[i] + " ");
        }
        Console.WriteLine();
    }
    
    public void printArray(int [] array) {
    	foreach(int x in array) {
    		Console.Write(x+" ");
    	}
    }

}
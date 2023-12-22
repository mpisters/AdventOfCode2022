namespace AdventOfCode2022.Day7;

public class GenericTree
{


// Utility function to create a new tree node
    public static Node NewNode(string key)
    {
        Node temp = new Node();
        temp.key = key;
        return temp;
    }

// Prints the n-ary tree level wise
    public static void LevelOrderTraversal(Node root)
    {
        if (root == null)
            return;

        // Standard level order traversal code
        // using queue
        Queue<Node > q = new Queue<Node >(); // Create a queue
        q.Enqueue(root); // Enqueue root
        while (q.Count != 0)
        {
            int n = q.Count;

            // If this node has children
            while (n > 0)
            {
                // Dequeue an item from queue
                // and print it
                Node p = q.Peek();
                q.Dequeue();
                Console.Write(p.key + " ");

                // Enqueue all children of
                // the dequeued item
                for (int i = 0; i < p.child.Count; i++)
                    q.Enqueue(p.child[i]);
                n--;
            }
		
            // Print new line between two levels
            Console.WriteLine();
        }
    }

// // Driver Code
//     public static void Main(String[] args)
//     {
// 	
//         /* Let us create below tree
//         *			 10
//         *	 / / \ \
//         *	 2 34 56 100
//         *	 / \		 | / | \
//         *	 77 88	 1 7 8 9
//         */
//         Node root = NewNode(10);
//         (root.child).Add(NewNode(2));
//         (root.child).Add(NewNode(34));
//         (root.child).Add(NewNode(56));
//         (root.child).Add(NewNode(100));
//         (root.child[0].child).Add(NewNode(77));
//         (root.child[0].child).Add(NewNode(88));
//         (root.child[2].child).Add(NewNode(1));
//         (root.child[3].child).Add(NewNode(7));
//         (root.child[3].child).Add(NewNode(8));
//         (root.child[3].child).Add(NewNode(9));
//
//         Console.WriteLine("Level order traversal " +
//                           "Before Mirroring ");
//         LevelOrderTraversal(root);
//     }
}